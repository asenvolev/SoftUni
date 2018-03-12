namespace Services
{
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Services.Contracts;

    public class TripService : ITripService
    {
        private readonly BusTicketSystemContext Context;

        public TripService(BusTicketSystemContext context)
        {
            this.Context = context;
        }

        public Trip ById(int id)
        {
            var trip = Context.Trips.Find(id);
            return trip;
        }
    }
}
