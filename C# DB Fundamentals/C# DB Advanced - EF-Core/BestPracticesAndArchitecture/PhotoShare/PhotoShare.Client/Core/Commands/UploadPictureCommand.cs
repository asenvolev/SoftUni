namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class UploadPictureCommand
    {
        // UploadPicture <albumName> <pictureTitle> <pictureFilePath>
        public static string Execute(string[] data)
        {
            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            string albumName = data[0];
            string pictureTitle = data[1];
            string pictureFilePath = data[2];

            using (var context = new PhotoShareContext())
            {
                if (!context.Albums.Any(x => x.Name == albumName))
                {
                    throw new ArgumentException($"Album {albumName} not found!");
                }

                var album = context.Albums.SingleOrDefault(x => x.Name == albumName);

                var pic = new Picture()
                {
                    Title = pictureTitle,
                    Path = pictureFilePath
                };

                album.Pictures.Add(pic);

                context.Pictures.Add(pic);
                context.SaveChanges();

                return $"Picture {pictureTitle} added to {albumName}!";
            }
        }
    }
}
