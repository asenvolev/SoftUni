using System;
using System.Linq;

namespace InversionCount
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(InversionCounter(input));
        }

        private static int InversionCounter(int[] arr)
        {
            int counter = 0;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = j+1; i < arr.Length; i++)
                {
                    if (arr[j] >= arr[i])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}
