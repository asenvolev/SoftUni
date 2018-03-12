using System;
using P02_DatabaseFirst.Data;
using System.Linq;

namespace EmployeesFullInformation
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();

            using (dbContext)
            {
                var employees = dbContext.Employees
                    .OrderBy(e => e.EmployeeId)
                    .Select(e => new
                    {
                        result = $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}"
                    })
                    .ToList();
                foreach (var empl in employees)
                {
                    Console.WriteLine(empl.result);
                }
            }
        }
    }
}
