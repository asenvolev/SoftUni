using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine().Split(new[] { ' ','\t','\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var list = new List<int>();
            string OddOrEven = Console.ReadLine();
            for (int i = range[0]; i <= range[1]; i++)
            {
                list.Add(i);
            }
            if (OddOrEven == "odd")
            {
                Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 1|| x % 2 == -1)));
            }
            else if (OddOrEven == "even")
            {
                Console.WriteLine(string.Join(" ", list.Where(x=>x%2==0)));
            }
        }
    }
}
