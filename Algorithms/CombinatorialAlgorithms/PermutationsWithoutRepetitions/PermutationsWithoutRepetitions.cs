using System;
using System.Linq;

namespace PermutationsWithoutRepetitions
{
    public class PermutationsWithoutRepetitions
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
                Permutate(index + 1);

                for (int i = index + 1; i < input.Length; i++)
                {
                    Swap(index, i);
                    Permutate(index + 1);
                    Swap(index, i);
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
