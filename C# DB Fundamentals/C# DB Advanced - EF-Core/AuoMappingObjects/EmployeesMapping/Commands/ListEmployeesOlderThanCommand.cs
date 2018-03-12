namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;
    using System.Text;

    public class ListEmployeesOlderThanCommand : ICommand
    {
        private readonly IEmployeeService service;

        public ListEmployeesOlderThanCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int age = int.Parse(args[0]);

            var listOfEmpl = service.ListEmployeesOlderThanAge(age);

            var sb = new StringBuilder();

            foreach (var empl in listOfEmpl)
            {
                if (empl.Manager != null)
                {
                    sb.AppendLine($"{empl.FirstName} {empl.LastName} - {empl.Salary} - Manager: {empl.Manager.FirstName} {empl.Manager.LastName}");
                }
                else
                {
                    sb.AppendLine($"{empl.FirstName} {empl.LastName} - {empl.Salary} - Manager: [no manager]");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
