using System;
using System.Linq;

namespace MergeSort
{
    public class MergeSorting
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            MergeSort(input, 0, input.Length-1);

            Console.WriteLine(string.Join(" ", input));
        }

        public static void MergeSort(int[] input, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int middle = (low + high) / 2;
            MergeSort(input, low, middle);
            MergeSort(input, middle + 1, high);
            Merge(input, low, middle, high);
        }

        private static void Merge(int[] arr, int low, int middle, int high)
        {
            if (middle<0 ||
                middle+1 >= arr.Length ||
                arr[middle] <= arr[middle+1])
            {
                return;
            }
            int left = low;
            int right = middle + 1;
            int[] tmp = new int[arr.Length];

            for (int i = low; i <= high; i++)
            {
                tmp[i] = arr[i];
            }

            for (int i = low; i <= high; i++)
            {
                if (left > middle)
                {
                    arr[i] = tmp[right++];
                }
                else if (right > high)
                {
                    arr[i] = tmp[left++];
                }
                else if (tmp[left] <= tmp[right])
                {
                    arr[i] = tmp[left++];
                }
                else
                {
                    arr[i] = tmp[right++];
                }
            }

        }
        
    }
    
}
