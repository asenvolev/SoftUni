using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var x1 = 3 * h;
            var y1 = h;
            var m1 = h;
            var n1 = h;
            var m2 = 2 * h;
            var n2 = 4 * h;
            if (x > x1 || x < m1 && y > n1 || x > m2 && y > n1 || y > n2 || x<0 || y<0)
            {
                Console.WriteLine("outside");
            }
            else if (y == 0 && x >= 0 && x <= x1 || y == y1 && x >= 0 && x <= m1 || y == y1 && x >= m2 && x <= x1 || x == 0 && y >= 0 && y <= y1 || x == x1 && y >= 0 && y <= y1 || x == m1 && y >= n1 && y <= n2 || x == m2 && y >= n1 && y <= n2 || y == n2 && x >= m1 && x <= m2)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
    }
}
