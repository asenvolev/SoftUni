﻿namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Data;

    public class DeleteUser
    {
        // DeleteUser <username>
        public static string Execute(string[] data)
        {
            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            string username = data[0];
            using (PhotoShareContext context = new PhotoShareContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Username == username);
                if (user == null)
                {
                    throw new ArgumentException($"User with {username} was not found!");
                }
                else if (user.IsDeleted == true)
                {
                    throw new InvalidOperationException($"User {username} is already deleted!");
                }

                user.IsDeleted = true;
                context.SaveChanges();

                return $"User {username} was deleted successfully!";
            }
        }
    }
}
