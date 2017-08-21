using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            foreach (var item in input.ToList())
            {
                if (item<0)
                {
                    input.Remove(item);
                }
            }
            input.Reverse();
            bool isEmpty = !input.Any();
            if (isEmpty)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", input));

            }

        }
    }
}
