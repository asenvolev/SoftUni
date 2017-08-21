using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var exactSquare = new List<int>();
            foreach (var item in nums)
            {
                if (Math.Sqrt(item)%1==0)
                {
                    exactSquare.Add(item);
                }
            }
            exactSquare.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",exactSquare));
        }
    }
}
