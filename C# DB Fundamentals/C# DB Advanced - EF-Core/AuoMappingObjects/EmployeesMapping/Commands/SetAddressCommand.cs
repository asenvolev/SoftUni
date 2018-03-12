namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;
    using System.Linq;

    public class SetAddressCommand : ICommand
    {
        private readonly IEmployeeService service;

        public SetAddressCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            string address = string.Join(" ", args.Skip(1).ToArray());

            service.SetAddress(employeeId, address);

            return $"Employee with ID:{employeeId} address set successfully!";
        }
    }
}
