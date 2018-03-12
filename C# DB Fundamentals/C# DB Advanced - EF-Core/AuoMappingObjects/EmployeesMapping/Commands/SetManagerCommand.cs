namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;

    public class SetManagerCommand : ICommand
    {
        private readonly IEmployeeService service;

        public SetManagerCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            int managerId = int.Parse(args[1]);

            service.SetManager(employeeId,managerId);

            return $"Employee with ID: {managerId} is now manager to employee with ID: {employeeId}";
        }
    }
}
