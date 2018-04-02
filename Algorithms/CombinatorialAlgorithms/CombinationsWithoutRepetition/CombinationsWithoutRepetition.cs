using System;
using System.Linq;

namespace CombinationsWithoutRepetition
{
    public class CombinationsWithoutRepetition
    {
        public static char[] input;
        public static char[] combination;
        public static void Main()
        {
            input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var combinationLenght = int.Parse(Console.ReadLine());
            combination = new char[combinationLenght];
            Combine(0, 0);
        }

        private static void Combine(int index, int start)
        {
            if (index >= combination.Length)
            {
                Console.WriteLine(string.Join(" ", combination));
            }
            else
            {
                for (int i = start; i < input.Length; i++)
                {
                    combination[index] = input[i];
                    Combine(index + 1, i + 1);
                }
            }
        }
    }
}
