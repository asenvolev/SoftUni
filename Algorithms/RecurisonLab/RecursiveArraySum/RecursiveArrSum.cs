using System;
using System.Linq;

namespace RecursiveArraySum
{
    public class RecursiveArrSum
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var result = Sum(input, input.Length - 1);
            Console.WriteLine(result);
        }

        private static int Sum(int[] array, int index)
        {
            if (index == -1)
            {
                return 0;
            }

            return array[index] + Sum(array, --index);
        }
    }
}
