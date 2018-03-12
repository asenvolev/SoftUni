namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class ShareAlbumCommand
    {
        // ShareAlbum <albumId> <username> <permission>
        // For example:
        // ShareAlbum 4 dragon321 Owner
        // ShareAlbum 4 dragon11 Viewer
        public static string Execute(string[] data)
        {
            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            int albumId = int.Parse(data[0]);
            string username = data[1];
            if (data[2] != "Viewer" && data[2] != "Owner")
            {
                throw new ArgumentException(@"Permission must be either ""Owner"" or ""Viewer""!");
            }
            Role permission = (Role)Enum.Parse(typeof(Role), data[2]);

            using(var context = new PhotoShareContext())
            {
                if (context.Users.SingleOrDefault(x => x.Username == username) == null)
                {
                    throw new ArgumentException($"{username} not found!");
                }

                var user = context.Users.SingleOrDefault(x => x.Username == username);

                if (!context.Albums.Any(x => x.Id == albumId))
                {
                    throw new ArgumentException($"Album not found!");
                }

                var album = context.Albums.Find(albumId);

                context.AlbumRoles.Add(new AlbumRole()
                {
                    Album = album,
                    User = user,
                    Role = permission
                });
                context.SaveChanges();

                return $"Username {username} added to album {album.Name} ({permission.ToString()})";
            }
        }
    }
}
