using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace AddressesByTown
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();
            using (dbContext)
            {
                var addresses = dbContext.Addresses
                    .OrderByDescending(e => e.Employees.Count)
                    .ThenBy(t => t.Town.Name)
                    .ThenBy(at => at.AddressText)
                    .Select(x => new
                    {
                        AddressText = x.AddressText,
                        TownName = x.Town.Name,
                        EmployeeCount = x.Employees.Count
                    })
                    .Take(10)
                    .ToList();

                foreach (var addres in addresses)
                {
                    Console.WriteLine($"{addres.AddressText}, {addres.TownName} - {addres.EmployeeCount} employees");
                }
            }
        }
    }
}
