namespace BusTicketSystem.Commands
{
    using BusTicketSystem.Commands.Contracts;
    using Services.Contracts;

    public class publish_reviewCommand : ICommand
    {
        private readonly IReviewService service;

        public publish_reviewCommand(IReviewService serviceProvider)
        {
            this.service = serviceProvider;
        }

        public string Execute(string[] args)
        {
            int customerId = int.Parse(args[0]);
            float Grade = float.Parse(args[1]);
            string busCompanyName = args[2];
            string content = args[3];

            var review = service.Create(customerId, Grade, busCompanyName, content);

            return $"Customer {review.Customer.FirstName} {review.Customer.LastName} published review for company {busCompanyName}";
        }
    }
}
