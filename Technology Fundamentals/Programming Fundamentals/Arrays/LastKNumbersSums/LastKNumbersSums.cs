using System;

namespace LastKNumbersSums
{
    internal class LastKNumbersSums
    {
        private static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int numsForAddition = int.Parse(Console.ReadLine());
            var seq = new long[numbers];
            seq[0] = 1;
            for (int i = 1; i < numbers; i++)
            {
                long sum = 0;
                for (int j = i - 1; j >= 0 && j >= i - numsForAddition; j--)
                {
                    sum += seq[j];
                }
                seq[i] = sum;
            }
            Console.WriteLine(string.Join(" ", seq));
        }
    }
}