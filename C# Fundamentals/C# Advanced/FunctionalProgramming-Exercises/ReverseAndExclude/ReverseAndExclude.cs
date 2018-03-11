using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    class ReverseAndExclude
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var divisibleNum = int.Parse(Console.ReadLine());
            nums.Reverse();
            Console.WriteLine(string.Join(" ",nums.Where(x=>x%divisibleNum!=0)));
        }
    }
}
