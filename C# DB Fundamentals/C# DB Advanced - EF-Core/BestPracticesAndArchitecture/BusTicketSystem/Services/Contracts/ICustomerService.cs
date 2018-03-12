namespace Services.Contracts
{
    using BusTicketSystem.Models;

    public interface ICustomerService
    {
        Customer ById(int id);
    }
}
