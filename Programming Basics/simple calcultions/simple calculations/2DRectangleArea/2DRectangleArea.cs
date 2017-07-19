using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            var S = a * b;
            var P = 2 * (a + b);
            Console.WriteLine(S+"\n"+P);
        }
    }
}
