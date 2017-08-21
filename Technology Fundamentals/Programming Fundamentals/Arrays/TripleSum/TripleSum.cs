using System;
using System.Linq;

namespace TripleSum
{
    internal class TripleSum
    {
        private static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool a = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        a = false;
                    }
                }
            }
            if (a)
            {
                Console.WriteLine("No");
            }
        }
    }
}