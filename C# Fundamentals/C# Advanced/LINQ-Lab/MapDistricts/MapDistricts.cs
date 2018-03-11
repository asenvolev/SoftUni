using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDistricts
{
    class MapDistricts
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var bound = long.Parse(Console.ReadLine());
            input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(c =>
            {
                var tokens = c.Split(':');
                var currCity = tokens[0];
                var currPopulation = long.Parse(tokens[1]);
                return new { currCity, currPopulation };
            }).GroupBy(
                c => c.currCity,
                c => c.currPopulation,
                (city, population) => new
                {
                    currCity = city,
                    Populations = population.ToList()
                }
            ).Where(x => x.Populations.Sum() >= bound)
            .OrderByDescending(x => x.Populations.Sum())
            .ToList()
            .ForEach(x => Console.WriteLine($"{x.currCity}: {string.Join(" ", x.Populations.OrderByDescending(p => p).Take(5))}"));
        }
    }
}
