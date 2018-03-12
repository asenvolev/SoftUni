using System;
using System.Linq;

namespace SortWords
{
    public class SortWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            input.Sort();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
