namespace EmployeesMapping
{
    using Employees.Data;
    using Employees.Models;
    using Employees.Services;
    using Employees.App;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using AutoMapper;
    using System;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            //Seed();

            var serviceProvider = ServiceConfiguration();
            var engine = new Engine(serviceProvider);
            engine.Run();

        }

        private static void Seed()
        {
            using (var context = new EmployeesDbContext())
            {
                var date = DateTime.ParseExact("15-05-1995","dd-MM-yyyy", CultureInfo.InvariantCulture);
                var employee = new Employee
                {
                    FirstName = "Sasho",
                    LastName = "Petkov",
                    Salary = 2200,
                    Address = "Sofia ul Vitoshka 1",
                    BirthDay = date
                };

                var secondDate = DateTime.ParseExact("04-09-1993", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var secondEmployee = new Employee
                {
                    FirstName = "Iordan",
                    LastName = "Krapkov",
                    Salary = 1300,
                    Address = "Sofia Lulin 10",
                    BirthDay = secondDate
                };

                var thirdDate = DateTime.ParseExact("10-12-1988", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var thirdEmployee = new Employee
                {
                    FirstName = "Ceco",
                    LastName = "Cakov",
                    Salary = 1000,
                    Address = "Sofia Mladost 2",
                    BirthDay = thirdDate
                };

                var fourthDate = DateTime.ParseExact("5-01-1983", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var fourthEmployee = new Employee
                {
                    FirstName = "Steve",
                    LastName = "Jobsseen",
                    Salary = 6000.20m,
                    Address = "London Hamburg",
                    BirthDay = fourthDate
                };

                var fifthDate = DateTime.ParseExact("25-03-1991", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var fifthEmployee = new Employee
                {
                    FirstName = "Kirilyc",
                    LastName = "Lefid",
                    Salary = 4400.30m,
                    Address = "Avghanistan Ojeanuedbv",
                    BirthDay = fifthDate
                };

                var sixthDate = DateTime.ParseExact("17-08-1996", "dd-MM-yyyy", CultureInfo.InvariantCulture);
                var sixthEmployee = new Employee
                {
                    FirstName = "Kirilyc",
                    LastName = "Lefid",
                    Salary = 4400.30m,
                    Address = "China Pekin",
                    BirthDay = sixthDate
                };

                context.Employees.AddRange(employee, secondEmployee, thirdEmployee, fourthEmployee, fifthEmployee, sixthEmployee);
                context.SaveChanges();
            }
        }

        private static IServiceProvider ServiceConfiguration()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<EmployeesDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<IEmployeeService,EmployeeService>();

            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile<AutomapperProfile>());

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
