using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleReport
{
    class SaleReport
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            var Sales = new SortedDictionary<string, decimal>();
            for (int i = 0; i < numInputs; i++)
            {
                var input = Console.ReadLine().Split();
                var currSale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };
                if (!Sales.ContainsKey(currSale.Town))
                {
                    Sales[currSale.Town] = 0;
                }
                Sales[currSale.Town] += currSale.Total;
            }
            foreach (var item in Sales)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
