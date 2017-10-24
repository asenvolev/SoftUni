using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibrary
{
    class BookLibrary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Book currBook = new Book
                {
                    Name = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    Date = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = int.Parse(input[4]),
                    Price = double.Parse(input[5])
                };
                if (!result.ContainsKey(currBook.Author))
                {
                    result.Add(currBook.Author, 0);
                }
                result[currBook.Author] += currBook.Price;
            }
            var finalResult = result
                .OrderByDescending(b => b.Value)
                .ThenBy(b => b.Key);
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
