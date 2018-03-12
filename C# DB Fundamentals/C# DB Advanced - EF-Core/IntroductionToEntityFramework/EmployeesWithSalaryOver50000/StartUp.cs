using System;
using P02_DatabaseFirst.Data;
using System.Linq;

namespace EmployeesWithSalaryOver50000
{
    public class StartUp
    {
        public static void Main()
        {
            var dbContext = new SoftUniContext();
            using (dbContext)
            {
                var emplWitSalary = dbContext.Employees
                    .Where(e=>e.Salary>50000)
                    .OrderBy(e => e.FirstName)
                    .Select(x=>x.FirstName)
                    .ToList();

                Console.WriteLine(string.Join("\r\n", emplWitSalary));
            }
        }
    }
}
