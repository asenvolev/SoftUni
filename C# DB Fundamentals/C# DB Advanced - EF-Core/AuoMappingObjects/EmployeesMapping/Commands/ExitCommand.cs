namespace Employees.App.Commands
{
    using Employees.App.Commands.Contracts;
    using System;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
