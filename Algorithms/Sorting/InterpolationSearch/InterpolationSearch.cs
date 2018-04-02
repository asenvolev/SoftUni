using System;
using System.Linq;

namespace InterpolationSearch
{
    public class InterpolationSearch
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var key = int.Parse(Console.ReadLine());
            Console.WriteLine(InterpolationSearching(input,key));
        }

        public static int InterpolationSearching(int[] sortedArray, int key)
        {
            int low = 0;
            int high = sortedArray.Length - 1;

            while (sortedArray[low] <= key && sortedArray[high] >= key)
            {
                int mid = low + ((key - sortedArray[low]) * (high - low)) / (sortedArray[high] - sortedArray[low]);

                if (sortedArray[mid] < key)
                {
                    low = mid + 1;
                }
                else if (sortedArray[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            if (sortedArray[low] == key) return low;
            else return -1;
        }
    }
}
