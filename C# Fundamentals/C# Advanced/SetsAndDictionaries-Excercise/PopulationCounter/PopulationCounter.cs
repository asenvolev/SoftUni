using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var dict = new Dictionary<string, Dictionary<string, long>>();
            while (input[0]!="report")
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);
                if (dict.ContainsKey(country))
                {
                    if (dict[country].ContainsKey(city))
                    {
                        dict[country][city] += population;
                    }
                    else
                    {
                        dict[country].Add(city, population);
                    }
                }
                else
                {
                    dict.Add(country, new Dictionary<string, long>());
                    dict[country].Add(city, population);
                }
                input = Console.ReadLine().Split('|').ToArray();
            }
            foreach (var country in dict.OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(x=>x.Value)})");
                foreach (var city in country.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
