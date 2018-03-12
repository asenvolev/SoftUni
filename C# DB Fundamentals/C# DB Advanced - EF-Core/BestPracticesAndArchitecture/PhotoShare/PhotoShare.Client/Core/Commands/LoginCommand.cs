namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using PhotoShare.Data;

    public class LoginCommand
    {
        public static string Execute(string[] data)
        {
            string username = data[0];
            string password = data[1];

            using (var context = new PhotoShareContext())
            {
                if (Session.User != null)
                {
                    throw new ArgumentException($"You should logout first!");
                }
                if (context.Users.SingleOrDefault(x => x.Username == username && x.Password == password) == null)
                {
                    throw new ArgumentException($"Invalid username or password!");
                }

                var user = context.Users.SingleOrDefault(x => x.Username == username);

                Session.User = user;
                return $"User {username} successfully logged in!";
            }
        }
    }
}
