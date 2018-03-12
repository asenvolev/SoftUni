namespace Services
{
    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Services.Contracts;

    public class CustomerService : ICustomerService
    {
        private readonly BusTicketSystemContext Context;

        public CustomerService(BusTicketSystemContext context)
        {
            this.Context = context;
        }

        public Customer ById(int id)
        {
            var customer = Context.Customers.Find(id);

            return customer;
        }
    }
}
