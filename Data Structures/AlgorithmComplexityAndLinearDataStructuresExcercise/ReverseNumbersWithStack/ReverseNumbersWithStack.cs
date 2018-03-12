using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersWithStack
{
    public class ReverseNumbersWithStack
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>(input);

            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
