using System;
using System.Linq;

namespace VariationsWithRepetitions
{
    public class VariationsWithRepetitions
    {
        public static char[] input;
        public static char[] variation;
        public static void Main()
        {
            input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var variationLenght = int.Parse(Console.ReadLine());
            variation = new char[variationLenght];
            Variate(0);
        }

        private static void Variate(int index)
        {
            if (index >= variation.Length)
            {
                Console.WriteLine(string.Join(" ", variation));
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    variation[index] = input[i];
                    Variate(index + 1);
                }
            }
        }
    }
}
