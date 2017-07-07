using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class MatchTickets
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var type = Console.ReadLine().ToLower();
            var people = double.Parse(Console.ReadLine());
            var budgetfortransport = 0.0;
            var ticketPrice = 0.0;

            if (people <= 4)
            {
                budgetfortransport = 0.75;
            }
            else if (people <= 9 && people >= 5)
            {
                budgetfortransport = 0.6;
            }
            else if (people <= 24 && people >= 10)
            {
                budgetfortransport = 0.5;
            }
            else if (people <= 49 && people >= 25)
            {
                budgetfortransport = 0.4;
            }
            else
            {
                budgetfortransport = 0.25;
            }

            if (type=="vip")
            {
                ticketPrice = 499.99;
            }
            else if (type=="normal")
            {
                ticketPrice = 249.99;
            }
            var totalprice = people * ticketPrice + budget * budgetfortransport;
            if (budget >= totalprice)
            {
                var leftovers = budget - totalprice;
                Console.WriteLine("Yes! You have {0:f2} leva left.",leftovers);
            }
            else
            {
                var leftovers = Math.Abs(budget - totalprice);
                Console.WriteLine("Not enough money! You need {0:f2} leva.", leftovers);
            }
        }
    }
}
