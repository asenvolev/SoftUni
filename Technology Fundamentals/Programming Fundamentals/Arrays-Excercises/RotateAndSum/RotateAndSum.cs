using System;
using System.Linq;

namespace RotateAndSum
{
    internal class RotateAndSum
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int times = int.Parse(Console.ReadLine());
            int[] sum = new int[input.Length];
            for (int j = 0; j < times; j++)
            {
                int a = input[input.Length - 1];
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        input[0] = a;
                    }
                    else
                    {
                        input[i] = input[i - 1];
                    }
                }
                for (int i = 0; i < input.Length; i++)
                {
                    sum[i] += input[i];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}