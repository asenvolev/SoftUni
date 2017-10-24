using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public class Point
        {
            public double x { get; set; }
            public double y { get; set; }
        }
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var first = new Point
            {
                x = double.Parse(input[0]),
                y = double.Parse(input[1])
            };
            var secondInput = Console.ReadLine().Split(' ').ToList();

            var second = new Point
            {
                x = double.Parse(secondInput[0]),
                y = double.Parse(secondInput[1])
            };
            double result = CalcDistance(first, second);
            Console.WriteLine(result);
        }

        public static double CalcDistance(Point first, Point second)
        {
            double diffX = Math.Abs(first.x - second.x);
            double diffY = Math.Abs(first.y - second.y);
            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);
            return Math.Sqrt(powX + powY);
        }
    }
}
