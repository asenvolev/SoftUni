using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace EmployeesDromResearchAndDevelopment
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
                    .Where(d=>d.Department.Name == "Research and Development")
                    .OrderBy(s => s.Salary)
                    .ThenByDescending(f => f.FirstName)
                    .Select(e => new
                    {
                        result = $"{e.FirstName} {e.LastName} from Research and Development - ${e.Salary:f2}"
                    })
                    .ToList()
                    .ForEach(x=>Console.WriteLine(x.result));
            }
        }
    }
}
