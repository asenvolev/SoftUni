using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace FindEmployeesByFirstNameStartingWithSa
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();

            using (dbContext)
            {
                var employeesWithSa = dbContext.
                    Employees
                    .Where(f => f.FirstName.Substring(0, 2) == "Sa")
                    .OrderBy(f => f.FirstName)
                    .ThenBy(l => l.LastName)
                    .Select(e => new
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        JobTitle = e.JobTitle,
                        Salary = e.Salary,
                        DepartmentName = e.Department.Name
                    })
                    .ToList();

                foreach (var empl in employeesWithSa)
                {
                    Console.Write($"{empl.FirstName} {empl.LastName} - {empl.JobTitle} - ");
                    if (empl.DepartmentName == "Engineering" ||
                                empl.DepartmentName == "Tool Design" ||
                                empl.DepartmentName == "Marketing" ||
                                empl.DepartmentName == "Information Services")
                    {
                        Console.WriteLine($"(${empl.Salary * 1.12m:f2})");
                    }
                    else
                    {
                        Console.WriteLine($"(${empl.Salary:f2})");
                    }
                }
            }
        }
    }
}
