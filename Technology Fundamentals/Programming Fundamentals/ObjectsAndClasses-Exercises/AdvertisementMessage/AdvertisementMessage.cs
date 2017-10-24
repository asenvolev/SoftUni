using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int n = int.Parse(Console.ReadLine());
            Random k = new Random();
            for (int i = 0; i < n; i++)
            {
                int randPhrase = k.Next(0, phrases.Length-1);
                int randEvents = k.Next(0, events.Length-1);
                int randAuthor = k.Next(0, author.Length-1);
                int randCities = k.Next(0, cities.Length-1);
                Console.WriteLine($"{phrases[randAuthor]} {events[randEvents]} {author[randAuthor]} - {cities[randCities]}");
            }
        }
    }
}
