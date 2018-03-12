using System;
using System.Linq;

namespace SumAndAverage
{
    public class SumAndAverage
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sum = input.Sum();
            double average = (double)sum / (double)input.Count();
            Console.WriteLine($"Sum={sum}; Average={average:f2}");
        }
    }
}
