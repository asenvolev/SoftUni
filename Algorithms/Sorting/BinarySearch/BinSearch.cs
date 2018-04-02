using System;
using System.Linq;

namespace BinarySearch
{
    public class BinSearch
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var key = int.Parse(Console.ReadLine());
            Console.WriteLine(BinarySearch(input, key,0,input.Length-1));
        }

        private static int BinarySearch(int[] input, int key, int start, int end)
        {
            if (end<start)
            {
                return -1;
            }
            else
            {
                int mid = (start + end) / 2;
                if (input[mid] < key)
                {
                    return BinarySearch(input, key, mid + 1, end);
                }
                else if (input[mid] > key)
                {
                    return BinarySearch(input, key, start, mid - 1);
                }
                else
                {
                    return mid;
                }
            }
        }
    }
}
