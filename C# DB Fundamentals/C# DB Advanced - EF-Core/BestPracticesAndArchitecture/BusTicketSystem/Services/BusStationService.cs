namespace Services
{
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Services.Contracts;

    public class BusStationService : IBusStationService
    {
        private readonly BusTicketSystemContext Context;

        public BusStationService(BusTicketSystemContext context)
        {
            this.Context = context;
        }

        public BusStation ById(int id)
        {
            var busStation = Context.BusStations.Find(id);
            return busStation;
        }
    }
}
