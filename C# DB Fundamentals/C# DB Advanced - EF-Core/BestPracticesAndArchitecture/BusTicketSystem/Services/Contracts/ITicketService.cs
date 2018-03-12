namespace Services.Contracts
{
    using BusTicketSystem.Models;

    public interface ITicketService
    {
        Ticket Create(int customerId, int tripId, decimal price, string seat);
    }
}
