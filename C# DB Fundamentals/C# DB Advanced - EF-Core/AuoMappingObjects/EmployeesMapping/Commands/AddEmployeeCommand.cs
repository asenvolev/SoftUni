namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using Employees.Services;
    using System;

    public class AddEmployeeCommand : ICommand
    {
        private readonly IEmployeeService service;

        public AddEmployeeCommand(IEmployeeService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            string firstName = args[0];
            string lastName = args[1];
            decimal salary = decimal.Parse(args[2]);

            service.AddEmployee(firstName, lastName, salary);

            return $"Employee {firstName} added successfully!";
        }
    }
}
