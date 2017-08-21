using System;
using System.Linq;

namespace FoldAndSum
{
    internal class FoldAndSum
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] firstPart = new int[k];
            int[] secondPart = new int[k];
            int[] middle = new int[k * 2];
            for (int i = 0; i < k; i++)
            {
                firstPart[i] = input[k - 1 - i];
                secondPart[i] = input[k * 4 - 1 - i];
            }

            for (int i = 0; i < k; i++)
            {
                middle[i] += firstPart[i] + input[k + i];
                middle[k + i] += secondPart[i] + input[k * 2 + i];
            }

            Console.WriteLine(string.Join(" ", middle));
        }
    }
}