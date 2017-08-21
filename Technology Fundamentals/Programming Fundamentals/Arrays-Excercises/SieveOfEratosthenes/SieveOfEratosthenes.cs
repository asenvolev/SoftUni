using System;

namespace SieveOfEratosthenes
{
    internal class SieveOfEratosthenes
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool[] arr = new bool[input + 1];
            for (int i = 0; i <= input; i++)
            { arr[i] = true; }
            arr[0] = false; arr[1] = false;
            for (int i = 0; i < input + 1; i++)
            {
                if (arr[i])
                {
                    for (int j = 2; (j * i) <= input; j++)
                    { arr[j * i] = false; }
                }
            }
            for (int j = 2; j <= input; j++)
            {
                if (arr[j] == true) { Console.Write(j + " "); }
            }
        }
    }
}