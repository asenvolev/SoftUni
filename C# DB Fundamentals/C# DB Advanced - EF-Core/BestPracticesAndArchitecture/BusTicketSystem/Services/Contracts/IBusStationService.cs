using BusTicketSystem.Models;

namespace Services.Contracts
{
    public interface IBusStationService
    {
        BusStation ById(int id);
    }
}
