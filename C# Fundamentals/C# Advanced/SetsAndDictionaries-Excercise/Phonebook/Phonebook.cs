using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, string>();
            while (input[0] != "search")
            {
                if (dict.ContainsKey(input[0]))
                {
                    dict[input[0]] = input[1];
                }
                else
                {
                    dict.Add(input[0], input[1]);
                }
                input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (input[0]!="stop")
            {
                if (dict.ContainsKey(input[0]))
                {
                    Console.WriteLine($"{input[0]} -> {dict[input[0]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input[0]} does not exist.");
                }
                input = Console.ReadLine().Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
