using System;
using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System.Linq;

namespace AddingАNewAddressАndUpdatingEmployee
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();
            using (dbContext)
            {
                var newAddress = new Address()
                {
                    AddressText = "Vitoshka 15",
                    TownId = 4
                };

                dbContext.Addresses.Add(newAddress);
                dbContext.SaveChanges();

                var nakovAdress = dbContext.Employees.Where(n => n.LastName == "Nakov").FirstOrDefault();
                nakovAdress.Address = newAddress;
                dbContext.SaveChanges();

                var addresses = dbContext.Employees
                    .OrderByDescending(a => a.AddressId)
                    .Take(10).Select(x => x.Address.AddressText).ToList();

                dbContext.SaveChanges();

                foreach (var address in addresses)
                {
                    Console.WriteLine(address);
                }
            }
        }
    }
}
