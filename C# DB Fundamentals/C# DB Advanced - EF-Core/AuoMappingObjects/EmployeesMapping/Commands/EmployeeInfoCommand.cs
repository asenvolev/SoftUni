namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;

    public class EmployeeInfoCommand : ICommand
    {
        private readonly IEmployeeService service;

        public EmployeeInfoCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            var employee = service.GetEmployeeById(employeeId);

            return $"ID: {employeeId} - {employee.FirstName} {employee.LastName} -  ${employee.Salary:f2}";
        }
    }
}
