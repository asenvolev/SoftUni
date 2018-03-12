namespace Services.Contracts
{
    using BusTicketSystem.Models;

    public interface IReviewService
    {
        Review Create(int customerId, float Grade, string busCompanyName, string content);
    }
}
