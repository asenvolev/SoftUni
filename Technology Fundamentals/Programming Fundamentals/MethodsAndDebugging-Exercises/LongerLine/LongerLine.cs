using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class LongerLine
    {
        static void Main()
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal x3 = decimal.Parse(Console.ReadLine());
            decimal y3 = decimal.Parse(Console.ReadLine());
            decimal x4 = decimal.Parse(Console.ReadLine());
            decimal y4 = decimal.Parse(Console.ReadLine());

            PrintClosestPoint(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        public static void PrintClosestPoint(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3, decimal x4, decimal y4)
        {
            if (Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2) >= Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4))
            {
                if (Math.Abs(x1) + Math.Abs(y1) <= Math.Abs(x2) + Math.Abs(y2))
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }

            }
            else
            {
                if (Math.Abs(x3) + Math.Abs(y3) <= Math.Abs(x4) + Math.Abs(y4))
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }

        }
    }
}
