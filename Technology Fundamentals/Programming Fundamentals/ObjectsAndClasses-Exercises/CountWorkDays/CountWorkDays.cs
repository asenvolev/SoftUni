using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkDays
{
    class CountWorkDays
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workDaysCounter = 0;

            var holidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };
            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate=currentDate.AddDays(1))
            {
                DateTime checkDate = new DateTime(2016, currentDate.Month, currentDate.Day);

                if (currentDate.DayOfWeek!= DayOfWeek.Saturday 
                    && currentDate.DayOfWeek!= DayOfWeek.Sunday
                    && !holidays.Contains(checkDate))
                {
                    workDaysCounter++;
                }
            }
            Console.WriteLine(workDaysCounter);
        }
    }
}
