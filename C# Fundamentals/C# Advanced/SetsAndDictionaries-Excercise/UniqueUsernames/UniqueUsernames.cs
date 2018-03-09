using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    public class UniqueUsernames
    {
        public static void Main()
        {
            var times = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < times; i++)
            {
                set.Add(Console.ReadLine());
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
