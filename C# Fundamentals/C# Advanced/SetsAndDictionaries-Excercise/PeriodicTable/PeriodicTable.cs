using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    public class PeriodicTable
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int k = 0; k < input.Length; k++)
                {
                    set.Add(input[k]);
                }
            }
            Console.WriteLine(string.Join(" ", set));
        }
    }
}
