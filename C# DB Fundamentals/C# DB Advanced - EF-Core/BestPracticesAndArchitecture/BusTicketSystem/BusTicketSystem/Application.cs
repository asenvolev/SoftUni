namespace BusTicketSystem
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using Services.Contracts;
    using Services;
    using BusTicketSystem.Data;
    using Microsoft.EntityFrameworkCore;

    public class Application
    {
        public static void Main()
        {
            var serviceProvider = ConfigureServices();
            var engine = new Engine(serviceProvider);
            engine.Run();
        }

        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<BusTicketSystemContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<ICustomerService, CustomerService>();
            serviceCollection.AddTransient<IBusCompanyService, BusCompanyService>();
            serviceCollection.AddTransient<IBusStationService, BusStationService>();
            serviceCollection.AddTransient<IReviewService, ReviewService>();
            serviceCollection.AddTransient<ITicketService, TicketService>();
            serviceCollection.AddTransient<ITripService, TripService>();
            
            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
