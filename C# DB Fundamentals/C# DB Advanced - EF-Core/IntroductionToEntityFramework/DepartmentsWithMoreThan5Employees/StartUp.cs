using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace DepartmentsWithMoreThan5Employees
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();
            using (dbContext)
            {
                var departments = dbContext.Departments
                    .Where(ec => ec.Employees.Count > 5)
                    .OrderBy(ec => ec.Employees.Count)
                    .ThenBy(dn => dn.Name)
                    .Select(x => new
                    {
                        Name = x.Name,
                        ManagerName = $"{x.Manager.FirstName} {x.Manager.LastName}",
                        Employees = x.Employees.Select(e=> new
                        {
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            JobTitle = e.JobTitle
                        })
                    })
                    .ToList();

                foreach (var dep in departments)
                {
                    Console.WriteLine($"{dep.Name} - {dep.ManagerName}");
                    foreach (var empl in dep.Employees.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName))
                    {
                        Console.WriteLine($"{empl.FirstName} {empl.LastName} - {empl.JobTitle}");
                    }
                    Console.WriteLine("----------");
                }
            }
        }
    }
}
