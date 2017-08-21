using System;
using System.Linq;

namespace EqualSums
{
    internal class EqualSums
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftsum = 0;
            int rightsum = 0;
            bool flag = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftsum += input[j];
                }
                for (int l = i + 1; l < input.Length; l++)
                {
                    rightsum += input[l];
                }
                if (leftsum == rightsum)
                {
                    Console.WriteLine(i);
                    flag = true;
                    break;
                }
                leftsum = 0;
                rightsum = 0;
            }
            if (!flag)
            {
                Console.WriteLine("no");
            }
        }
    }
}