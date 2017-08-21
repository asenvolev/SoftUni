using System;
using System.Linq;

namespace SumArrays
{
    internal class SumArrays
    {
        private static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var bigArr = Math.Max(firstArr.Length, secondArr.Length);
            int[] sumArr = new int[bigArr];

            for (int i = 0; i < bigArr; i++)
            {
                sumArr[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}