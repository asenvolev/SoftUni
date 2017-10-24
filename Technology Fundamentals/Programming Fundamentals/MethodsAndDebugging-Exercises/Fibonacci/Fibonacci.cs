using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var f1 = 1;
            var f2 = 1;
            for (int i = 1; i < n; i++)
            {
                var next = f1 + f2;
                f1 = f2;
                f2 = next;
            }
            Console.WriteLine(f2);
        }
    }
}
