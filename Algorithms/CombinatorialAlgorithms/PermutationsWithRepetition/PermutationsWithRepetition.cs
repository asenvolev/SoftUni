using System;
using System.Collections.Generic;
using System.Linq;

namespace PermutationsWithRepetition
{
    public class PermutationsWithRepetition
    {
        public static char[] input;
        public static void Main()
        {
            input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            Permutate(0);
        }

        private static void Permutate(int index)
        {
            if (index >= input.Length)
            {
                Console.WriteLine(string.Join(" ", input));
            }
            else
            {
                var swapped = new HashSet<char>();

                for (int i = index; i < input.Length; i++)
                {
                    if (!swapped.Contains(input[i]))
                    {
                        Swap(index, i);
                        Permutate(index + 1);
                        Swap(index, i);
                        swapped.Add(input[i]);
                    }
                }
            }
        }

        private static void Swap(int index, int i)
        {
            var temp = input[index];
            input[index] = input[i];
            input[i] = temp;
        }
    }
}
