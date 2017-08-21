using System;
using System.Linq;

namespace ReverseArrayOfStrings
{
    internal class ReverseArrayOfStrings
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var reverseInput = input.Reverse();
            Console.WriteLine(string.Join(" ", reverseInput));
        }
    }
}