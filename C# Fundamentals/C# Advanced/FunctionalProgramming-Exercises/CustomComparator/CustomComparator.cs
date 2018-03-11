using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomComparator
{
    class CustomComparator
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList()
                .OrderBy(x => x % 2 != 0)
                .ThenBy(x=>x%2==0)
                .ThenBy(x=>x)));
        }
    }
}
