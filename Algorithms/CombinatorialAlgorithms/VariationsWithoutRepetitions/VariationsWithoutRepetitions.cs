using System;
using System.Linq;

namespace VariationsWithoutRepetitions
{
    public class VariationsWithoutRepetitions
    {
        public static char[] input;
        public static char[] variation;
        public static bool[] used;
        public static void Main()
        {
            input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var variationLenght = int.Parse(Console.ReadLine());
            variation = new char[variationLenght];
            used = new bool[input.Length];
            Variate(0);
        }

        private static void Variate(int index)
        {
            if (index >= variation.Length)
            {
                Console.WriteLine(string.Join(" ",variation));
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        variation[index] = input[i];
                        Variate(index + 1);
                        used[i] = false;
                    }
                    
                }
            }
        }
    }
}
