namespace Employees.App.Commands
{
    using System.Text;

    using Employees.App.Commands.Contracts;
    using Employees.Services;

    public class ManagerInfo : ICommand
    {
        private readonly IEmployeeService service;

        public ManagerInfo(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);

            var manager = service.ManagerInfo(employeeId);

            var sb = new StringBuilder();

            sb.AppendLine($"{manager.FirstName} {manager.LastName} | Employees: {manager.ManagedEmployees.Count}");

            foreach (var empl in manager.ManagedEmployees)
            {
                sb.AppendLine($"\t- {empl.FirstName} {empl.LastName} - ${empl.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
