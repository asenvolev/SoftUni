namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class RegisterUserCommand
    {
        // RegisterUser <username> <password> <repeat-password> <email>
        public static string Execute(string[] data)
        {
            if (Session.User != null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }
            if (data.Length<4)
            {
                throw new ArgumentException("Command RegisterUser not valid");
            }
            string username = data[0];
            string password = data[1];
            string repeatPassword = data[2];
            string email = data[3];

            if (password != repeatPassword)
            {
                throw new ArgumentException("Passwords do not match!");
            }
            User user;
            using (PhotoShareContext context = new PhotoShareContext())
            {
                if (context.Users.SingleOrDefault(u=>u.Username == username) != null)
                {
                    throw new InvalidOperationException($"Username {username} is already taken!");
                }

                user = new User
                {
                    Username = username,
                    Password = password,
                    Email = email,
                    IsDeleted = false,
                    RegisteredOn = DateTime.Now,
                    LastTimeLoggedIn = DateTime.Now
                };

                context.Users.Add(user);
                context.SaveChanges();
            }

            return $"User {user.Username} was registered successfully!";
        }
    }
}
