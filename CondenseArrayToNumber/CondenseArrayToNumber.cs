using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    internal class CondenseArrayToNumber
    {
        private static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] condensed = new int[arr.Length - 1];
            if (arr.Length == 1)
            {
                Console.WriteLine($"{arr[0]} is already condensed to number");
            }
            else
            {
                for (int k = 0; k < condensed.Length; k++)
                {
                    for (int i = 0; i < condensed.Length; i++)
                    {
                        condensed[i] = arr[i] + arr[i + 1];
                    }
                    for (int j = 0; j < condensed.Length; j++)
                    {
                        arr[j] = condensed[j];
                    }
                }

                Console.WriteLine(condensed[0]);
            }
        }
    }
}