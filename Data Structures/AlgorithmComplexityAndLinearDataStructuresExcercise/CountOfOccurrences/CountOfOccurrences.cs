using System;
using System.Collections.Generic;
using System.Linq;

namespace CountOfOccurrences
{
    public class CountOfOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            input.Sort();

            var dict = new Dictionary<int, int>();

            foreach (var num in input)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }
            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} -> {num.Value} times");
            }


        }
    }
}
