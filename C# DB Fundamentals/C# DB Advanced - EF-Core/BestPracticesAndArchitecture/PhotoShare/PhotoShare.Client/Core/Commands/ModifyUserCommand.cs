namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class ModifyUserCommand
    {
        // ModifyUser <username> <property> <new value>
        // For example:
        // ModifyUser <username> Password <NewPassword>
        // ModifyUser <username> BornTown <newBornTownName>
        // ModifyUser <username> CurrentTown <newCurrentTownName>
        // !!! Cannot change username
        public static string Execute(string[] data)
        {
            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            string username = data[0];
            string property = data[1];
            string newValue = data[2];

            using (PhotoShareContext context = new PhotoShareContext())
            {
                if (context.Users.SingleOrDefault(x => x.Username == username) == null)
                {
                    throw new ArgumentException($"User {username} not found!");
                }

                var user = context.Users.SingleOrDefault(x => x.Username == username);

                switch (property.ToLower())
                {
                    default:
                        throw new ArgumentException($"Property {property} not supported!");
                    case "password":
                        if (!newValue.Any(c => char.IsLower(c)) || !newValue.Any(c => char.IsUpper(c)))
                        {
                            throw new ArgumentException($"Value {property} not valid.\r\nInvalid Password");
                        }

                        user.Password = newValue;

                        break;
                    case "borntown":
                        if (context.Towns.SingleOrDefault(x=>x.Name == newValue) == null)
                        {
                            throw new ArgumentException($"Value {property} not valid.\r\nTown {newValue} not found!");
                        }

                        user.BornTown = context.Towns.SingleOrDefault(x => x.Name == newValue);

                        break;
                    case "currenttown":
                        if (context.Towns.SingleOrDefault(x => x.Name == newValue) == null)
                        {
                            throw new ArgumentException($"Value {property} not valid.\r\nTown {newValue} not found!");
                        }

                        user.CurrentTown = context.Towns.SingleOrDefault(x => x.Name == newValue);

                        break;
                }
                
                context.SaveChanges();

                return $"User {username} {property} is {newValue}.";
            }
        }
    }
}
