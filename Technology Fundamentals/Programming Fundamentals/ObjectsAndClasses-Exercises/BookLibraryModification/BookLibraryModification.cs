using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BookLibraryModification
{
    class BookLibraryModification
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, DateTime>();
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
                if (!result.ContainsKey(currBook.Name))
                {
                    result.Add(currBook.Name, currBook.Date);
                }
                else
                {
                    result[currBook.Name] = currBook.Date;
                }
            }
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var finalResult = result
                .Where(b => b.Value > startDate)
                .OrderBy(b => b.Value)
                .ThenBy(b => b.Key);
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.ToString("dd.MM.yyyy")}");
            }
        }
    }
}
