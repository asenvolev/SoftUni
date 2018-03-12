namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class AddTagToCommand 
    {
        // AddTagTo <albumName> <tag>
        public static string Execute(string[] data)
        {
            string albumName = data[0];
            string tagName = data[1];

            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(x => x.Name == albumName) || context.Tags.Any(x => !(x.Name == tagName)))
                {
                    throw new ArgumentException($"Either tag or album do not exist!");
                }

                var album = context.Albums.SingleOrDefault(x => x.Name == albumName);
                var tag = context.Tags.SingleOrDefault(x => x.Name == tagName);

                context.AlbumTags.Add(new AlbumTag()
                {
                    Album = album,
                    Tag = tag
                });
                context.SaveChanges();

                return $"Tag {tagName} added to {albumName}!";
            }
        }
    }
}
