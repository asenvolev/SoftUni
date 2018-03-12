using System;
using System.Linq;
using P02_DatabaseFirst.Data;
using System.Globalization;
namespace EmployeesAndProjects
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();

            using (dbContext)
            {
                var employees = dbContext.Employees
                    .Where(e => e.EmployeeProjects.Any(ep => ep.Project.StartDate.Year > 2000 &&
                      ep.Project.StartDate.Year < 2004))
                    .Select(e => new
                    {
                        Name = $"{e.FirstName} {e.LastName}",
                        ManagerName = $"{e.Manager.FirstName} {e.Manager.LastName}",
                        Projects = e.EmployeeProjects.Select(ep => new
                        {
                            ep.Project.Name,
                            ep.Project.StartDate,
                            ep.Project.EndDate
                        })
                    }).Take(30).ToList();

                foreach (var empl in employees)
                {
                    Console.WriteLine($"{empl.Name} – Manager: {empl.ManagerName}");
                    foreach (var proj in empl.Projects)
                    {
                        Console.Write($"--{ proj.Name} - {proj.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - ");
                        if (proj.EndDate == null)
                        {
                            Console.WriteLine("not finished");
                        }
                        else
                        {
                            Console.WriteLine($"{proj.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
            }
        }
    }
}
