using System;

namespace NestedLoopsToRecursion
{
    public class NestedLoopsToRecursion
    {
        public static void Main()
        {
            int maxIndex = int.Parse(Console.ReadLine());
            var vector = new int[maxIndex];
            PrintAllVariants(vector);
        }

        private static void PrintAllVariants(int[] arr, int currIndex = 0)
        {
            if (currIndex == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[currIndex] = i;
                    PrintAllVariants(arr,currIndex+1);
                }
            }


        }
    }
}
