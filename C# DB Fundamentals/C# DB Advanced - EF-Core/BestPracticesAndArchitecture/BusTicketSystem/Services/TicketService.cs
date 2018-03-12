namespace Services
{
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Services.Contracts;

    public class TicketService : ITicketService
    {
        private readonly BusTicketSystemContext Context;
        private CustomerService customerService;
        private TripService tripService;

        public TicketService(BusTicketSystemContext context)
        {
            this.Context = context;
            this.customerService = new CustomerService(this.Context);
            this.tripService = new TripService(this.Context);
        }

        public Ticket Create(int customerId, int tripId, decimal price, string seat)
        {
            var customer = this.customerService.ById(customerId);
            var trip = this.tripService.ById(tripId);

            var ticket = new Ticket
            {
                Customer = customer,
                CustomerId = customerId,
                Trip = trip,
                TripId = tripId,
                Price = price,
                Seat = seat
            };

            Context.Tickets.Add(ticket);
            Context.SaveChanges();

            return ticket;
        }
    }
}
