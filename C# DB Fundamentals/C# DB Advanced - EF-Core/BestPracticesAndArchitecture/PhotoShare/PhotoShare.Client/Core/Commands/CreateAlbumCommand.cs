namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Models;
    using Data;
    using PhotoShare.Client.Utilities;

    public class CreateAlbumCommand
    {
        // CreateAlbum <username> <albumTitle> <BgColor> <tag1> <tag2>...<tagN>
        public static string Execute(string[] data)
        {
            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            string username = data[0];
            string albumTitle = data[1];
            string BgColor = data[2];
            var tags = data.Skip(3).Select(x=>x.ValidateOrTransform()).ToArray();

            using (PhotoShareContext context = new PhotoShareContext())
            {
                if (!context.Users.Any(x => x.Username == username))
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                if (context.Albums.Any(x => x.Name == albumTitle))
                {
                    throw new ArgumentException($"Album {albumTitle} exists!");
                }
                
                if (!Enum.IsDefined(typeof(Color), BgColor))
                {
                    throw new ArgumentException($"Color {BgColor} not found!");
                }
                
                if (context.Tags.Any(x => !tags.Contains(x.Name)))
                {
                    throw new ArgumentException($"Invalid tags!");
                }

                var album = new Album()
                {
                    Name = albumTitle,
                    BackgroundColor = (Color)Enum.Parse(typeof(Color), BgColor)
                };
                context.Albums.Add(album);
                foreach (var tag in tags)
                {
                    Tag foundTag = context.Tags.SingleOrDefault(x => x.Name == tag);

                    context.AlbumTags.Add(new AlbumTag()
                    {
                        Album = album,
                        Tag = foundTag
                    });
                }

                context.SaveChanges();

                return $"Album {albumTitle} is successfully created!";
            }
        }
    }
}
