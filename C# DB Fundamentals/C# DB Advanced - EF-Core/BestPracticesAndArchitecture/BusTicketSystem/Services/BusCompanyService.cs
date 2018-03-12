namespace Services
{
    using System.Linq;

    using BusTicketSystem.Data;
    using BusTicketSystem.Models;
    using Services.Contracts;

    public class BusCompanyService : IBusCompanyService
    {
        private readonly BusTicketSystemContext Context;

        public BusCompanyService(BusTicketSystemContext context)
        {
            this.Context = context;
        }

        public BusCompany ById(int id)
        {
            var busCompany = Context.BusCompanies.Find(id);
            return busCompany;
        }

        public BusCompany ByName(string name)
        {
            var busCompany = Context.BusCompanies.SingleOrDefault(x=>x.Name == name);
            return busCompany;
        }
    }
}
