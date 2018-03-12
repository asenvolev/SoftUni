namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;

    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly IEmployeeService service;

        public EmployeePersonalInfoCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            var employee = service.GetEmployeePersonalInfo(employeeId);

            return $"ID: {employeeId} - {employee.FirstName} {employee.LastName} -  ${employee.Salary:f2}\r\n" +
                $"Birthday: {employee.BirthDay.Value.Date.ToString("dd/MM/yyyy")}\r\nAddress: {employee.Address}";
        }
    }
}
