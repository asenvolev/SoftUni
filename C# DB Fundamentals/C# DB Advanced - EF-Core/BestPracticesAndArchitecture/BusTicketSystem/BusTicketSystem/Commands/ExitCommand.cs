namespace BusTicketSystem.Commands
{
    using BusTicketSystem.Commands.Contracts;
    using System;

    public class ExitCommand : ICommand
    {
        private readonly IServiceProvider serviceProvider;
        public ExitCommand(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Execute(string[] args)
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
