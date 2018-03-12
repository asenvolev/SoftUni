using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace Employee147
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();
            using (dbContext)
            {
                var employee147 = dbContext.Employees
                    .Where(n => n.EmployeeId == 147)
                    .Select(x => new
                    {
                        Name = $"{x.FirstName} {x.LastName}",
                        JobTitle = x.JobTitle,
                        Projects = x.EmployeeProjects.Select(p=>p.Project.Name)
                    })
                    .FirstOrDefault();
                
                Console.WriteLine($"{employee147.Name} - {employee147.JobTitle}");
                foreach (var proj in employee147.Projects.OrderBy(x=>x))
                {
                    Console.WriteLine(proj);
                }
                
            }
        }
    }
}
