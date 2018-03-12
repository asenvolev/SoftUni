using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace IncreaseSalaries
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();

            using (dbContext)
            {
                dbContext.
                    Employees
                    .Where(d => d.Department.Name == "Engineering" ||
                                d.Department.Name == "Tool Design" ||
                                d.Department.Name == "Marketing" ||
                                d.Department.Name == "Information Services")
                    .OrderBy(f => f.FirstName)
                    .ThenBy(l=>l.LastName)
                    .Select(e => new
                    {
                        result = $"{e.FirstName} {e.LastName} (${e.Salary*1.12m:f2})"
                    })
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.result));
                dbContext.SaveChanges();
            }
        }
    }
}
