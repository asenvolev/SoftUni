using System;
using System.Linq;
using P02_DatabaseFirst.Data;

namespace DeleteProjectById
{
    public class StartUp
    {
        public static void Main()
        {
            var dbcontext = new SoftUniContext();
            using (dbcontext)
            {
                var project = dbcontext.Projects.Where(p => p.ProjectId == 2).FirstOrDefault();
                var employees = dbcontext.EmployeesProjects.Where(p => p.ProjectId == 2);
                foreach (var empl in employees)
                {
                    dbcontext.EmployeesProjects.Remove(empl);
                }
                dbcontext.Projects.Remove(project);
                dbcontext.SaveChanges();

                dbcontext.Projects.Take(10).Select(n => n.Name).ToList().ForEach(x => Console.WriteLine(x));

            }
        }
    }
}
