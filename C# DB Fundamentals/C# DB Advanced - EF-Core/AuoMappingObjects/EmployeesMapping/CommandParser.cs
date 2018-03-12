namespace EmployeesMapping
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Employees.App.Commands.Contracts;

    public class CommandParser
    {
        public static ICommand ParseCommand(string commandName, IServiceProvider serviceProvider)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var commandTypes = assembly.GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ICommand)))
                .ToArray();

            var commandType = commandTypes.SingleOrDefault(t => t.Name == $"{commandName}Command");

            if (commandType == null)
            {
                throw new InvalidOperationException("Invalid Command");
            }

            var constructor = commandType.GetConstructors().First();

            var constructorParams = constructor.GetParameters().Select(pi => pi.ParameterType).ToArray();

            var services = constructorParams.Select(serviceProvider.GetService).ToArray();

            var command = (ICommand)constructor.Invoke(services);

            return command;
        }
    }
}