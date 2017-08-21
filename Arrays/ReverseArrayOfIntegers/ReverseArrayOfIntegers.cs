using System;

namespace ReverseArrayOfIntegers
{
    internal class ReverseArrayOfIntegers
    {
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = num - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}