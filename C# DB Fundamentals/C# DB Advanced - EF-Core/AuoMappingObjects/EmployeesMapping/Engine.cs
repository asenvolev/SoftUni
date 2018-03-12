namespace EmployeesMapping
{
    using System;
    using System.Linq;

    public class Engine
    {
        private IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine().Trim();
                    string[] data = input.Split(' ');
                    var commandName = data.First();
                    var commandArgs = data.Skip(1).ToArray();
                    var command = CommandParser.ParseCommand(commandName, serviceProvider);
                    var result = command.Execute(commandArgs);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}