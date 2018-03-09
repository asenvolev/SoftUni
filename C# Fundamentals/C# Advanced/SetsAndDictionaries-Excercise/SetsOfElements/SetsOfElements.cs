using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();
            var Set = new HashSet<int>();

            for (int i = 0; i < input[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < input[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }
            foreach (var elem in firstSet)
            {
                foreach (var item in secondSet)
                {
                    if (elem == item)
                    {
                        Set.Add(elem);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", Set));
        }
    }
}
