namespace BusTicketSystem.Commands
{
    using BusTicketSystem.Commands.Contracts;
    using Services.Contracts;

    public class buy_ticketCommand : ICommand
    {
        private readonly ITicketService service;

        public buy_ticketCommand(ITicketService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int customerId = int.Parse(args[0]);
            int tripId = int.Parse(args[1]);
            decimal price = decimal.Parse(args[2]);
            string seat = args[3];

            var ticket = service.Create(customerId, tripId, price, seat);

            return $"Customer {ticket.Customer.FirstName} {ticket.Customer.LastName} bought ticket for trip " +
                $"{ticket.TripId} for {ticket.Price} on seat {ticket.Seat}";
        }
    }
}
