using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class MinMaxSumAverage
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] num = new int[count];
            for (int i = 0; i < count; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            int sum = num.Sum();
            Console.WriteLine($"Sum = {sum}");
            int min = num.Min();
            Console.WriteLine($"Min = {min}");
            int max = num.Max();
            Console.WriteLine($"Max = {max}");
            double average = num.Average();
            Console.WriteLine($"Average = {average}");

        }
    }
}
