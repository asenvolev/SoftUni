using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numOfBuyers = int.Parse(Console.ReadLine());
            var buyers = new List<IBuyer>();
            for (int i = 0; i < numOfBuyers; i++)
            {
                var buyer = Console.ReadLine().Split();
                if (buyer.Length == 4)
                {
                    var citizen = new Citizen(buyer[0], int.Parse(buyer[1]), buyer[2], buyer[3]);
                    buyers.Add(citizen);
                }
                else
                {
                    var rebel = new Rebel(buyer[0], int.Parse(buyer[1]), buyer[2]);
                    buyers.Add(rebel);
                }
            }

            var input = Console.ReadLine();
            while (input!="End")
            {
                if (buyers.Any(x=>x.Name==input))
                {
                    IBuyer buyer = buyers.First(x => x.Name == input);
                    buyer.BuyFood();
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(buyers.Sum(x => x.Food));
        }
    }
}
