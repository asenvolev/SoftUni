namespace PhotoShare.Client.Core.Commands
{
    using System;
    using System.Linq;

    using Models;
    using Data;

    public class AddTownCommand
    {
        // AddTown <townName> <countryName>
        public static string Execute(string[] data)
        {
            string townName = data[0];
            string country = data[1];

            if (Session.User == null)
            {
                throw new InvalidOperationException($"Invalid credentials!");
            }

            using (PhotoShareContext context = new PhotoShareContext())
            {
                if (context.Towns.SingleOrDefault(x=>x.Name == townName) != null)
                {
                    throw new ArgumentException($"Town {townName} was already added!");
                }

                Town town = new Town
                {
                    Name = townName,
                    Country = country
                };

                context.Towns.Add(town);
                context.SaveChanges();

                return $"Town {town.Name} was added successfully!";
            }
        }
    }
}
