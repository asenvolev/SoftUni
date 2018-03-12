namespace BusTicketSystem
{
    using System;
    using System.Linq;

    public class Engine
    {
        private readonly IServiceProvider serviceProvider;

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
                    var commandArgs = data.Skip(1);
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
