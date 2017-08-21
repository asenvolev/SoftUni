using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int k = input.Count / 4;
            var right = input
                .Skip(3 * k)
                .Take(k)
                .Reverse();
            var row1 = input
                .Take(k)
                .Reverse()
                .Concat(right);
            var row2 = input
                .Skip(k)
                .Take(2 * k);
            var result = row1
                .Zip(row2, ((x,y) => x+y));
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
