using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace FindLatest10Projects
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();
            using (dbContext)
            {
                var projects = dbContext.Projects
                    .OrderByDescending(s => s.StartDate)
                    .Take(10)
                    .Select(x => new
                    {
                        Name = x.Name,
                        Description = x.Description,
                        StartDate = x.StartDate
                    })
                    .ToList();

                foreach (var proj in projects.OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"{proj.Name}\r\n{proj.Description}\r\n{proj.StartDate}");
                }
            }
        }
    }
}
