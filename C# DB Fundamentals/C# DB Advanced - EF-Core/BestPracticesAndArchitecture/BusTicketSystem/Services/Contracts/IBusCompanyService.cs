namespace Services.Contracts
{
    using BusTicketSystem.Models;

    public interface IBusCompanyService
    {
        BusCompany ByName(string name);

        BusCompany ById(int id);
    }
}
