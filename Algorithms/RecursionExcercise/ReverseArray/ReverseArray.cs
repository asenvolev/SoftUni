using System;
using System.Linq;

namespace ReverseArray
{
    public class ReverseArray
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            ReverseArr(input);

            Console.WriteLine(String.Join(" ", input));
        }

        private static void ReverseArr(int[] arr, int index = 0)
        {
            if (index == arr.Length/2)
            {
                return;
            }

            var tmp = arr[index];
            arr[index] = arr[arr.Length - 1 - index];
            arr[arr.Length - 1 - index] = tmp;

            ReverseArr(arr, index + 1);
        }
    }
}
