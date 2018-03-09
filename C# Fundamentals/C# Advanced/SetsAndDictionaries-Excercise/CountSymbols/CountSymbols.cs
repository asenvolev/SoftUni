using System;
using System.Collections.Generic;

namespace CountSymbols
{
    public class CountSymbols
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dict = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.ContainsKey(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict.Add(input[i], 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}