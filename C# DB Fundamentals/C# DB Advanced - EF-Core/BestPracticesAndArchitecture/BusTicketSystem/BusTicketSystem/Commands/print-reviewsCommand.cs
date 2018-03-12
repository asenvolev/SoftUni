namespace BusTicketSystem.Commands
{
    using BusTicketSystem.Commands.Contracts;
    using Services.Contracts;
    using System.Text;

    public class print_reviewsCommand : ICommand
    {
        private readonly IBusCompanyService service;

        public print_reviewsCommand(IBusCompanyService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int busCompanyId = int.Parse(args[0]);

            var busCompany = service.ById(busCompanyId);

            var sb = new StringBuilder();
            foreach (var item in busCompany.Reviews)
            {
                sb.AppendLine($"{item.Grade} {item.DateAndTimeOfPublishing}\r\n{item.Customer.FirstName} {item.Customer.LastName}\r\n {item.Content}");
            }

            return sb.ToString().Trim();
        }
    }
}
