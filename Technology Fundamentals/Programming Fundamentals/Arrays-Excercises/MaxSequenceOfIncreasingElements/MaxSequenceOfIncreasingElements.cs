using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    internal class MaxSequenceOfIncreasingElements
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            int start = 0;
            int maxCount = 0;
            int maxStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    count++;
                    start = i - count;

                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxStart = start;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = maxStart; i <= (maxStart + maxCount); i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}