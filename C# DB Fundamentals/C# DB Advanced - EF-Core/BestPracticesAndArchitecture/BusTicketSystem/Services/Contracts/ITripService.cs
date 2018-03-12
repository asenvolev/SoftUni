namespace Services.Contracts
{
    using BusTicketSystem.Models;

    public interface ITripService
    {
        Trip ById(int id);
    }
}
