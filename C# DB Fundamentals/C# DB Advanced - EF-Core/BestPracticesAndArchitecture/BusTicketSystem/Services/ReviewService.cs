namespace Services
{
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Services.Contracts;

    public class ReviewService : IReviewService
    {
        private readonly BusTicketSystemContext Context;
        private CustomerService customerService;
        private BusCompanyService busCompanyService;

        public ReviewService(BusTicketSystemContext context)
        {
            this.Context = context;
            this.customerService = new CustomerService(this.Context);
            this.busCompanyService = new BusCompanyService(this.Context);
        }

        public Review Create(int customerId, float Grade, string busCompanyName, string content)
        {
            var customer = this.customerService.ById(customerId);
            var busCompany = this.busCompanyService.ByName(busCompanyName);

            var review = new Review()
            {
                BusCompany = busCompany,
                BusCompanyId = busCompany.BusCompanyId,
                Customer = customer,
                CustomerId = customerId,
                Grade = Grade,
                Content = content
            };
            
            Context.Reviews.Add(review);
            Context.SaveChanges();

            return review;
        }
    }
}
