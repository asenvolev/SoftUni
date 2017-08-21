using System;
using System.Linq;

namespace RoundingNumbers
{
    internal class RoundingNumbers
    {
        private static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]}=>{roundedNums[i]}");
            }
        }
    }
}