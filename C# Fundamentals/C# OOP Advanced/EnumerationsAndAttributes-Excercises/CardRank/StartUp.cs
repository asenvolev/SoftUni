using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRank
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Console.WriteLine($"{input}:");
            foreach (var suit in Enum.GetValues(typeof(CardRank)))
            {
                Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
            }
        }
    }
}
