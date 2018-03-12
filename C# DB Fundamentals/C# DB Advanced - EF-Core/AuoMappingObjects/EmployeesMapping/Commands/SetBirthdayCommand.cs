namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;

    public class SetBirthdayCommand : ICommand
    {
        private readonly IEmployeeService service;

        public SetBirthdayCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            string date = args[1];

            service.SetBirthDay(employeeId, date);

            return $"Employee with ID:{employeeId} birthday set successfully!";
        }
    }
}
