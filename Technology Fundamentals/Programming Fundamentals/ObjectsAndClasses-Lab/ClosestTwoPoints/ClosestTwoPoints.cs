using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
   public class ClosestTwoPoints
    {
        class Point
        {
            public double x { get; set; }
            public double y { get; set; }

            public static Point readPoint()
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var point = new Point
                {
                    x = double.Parse(input[0]),
                    y = double.Parse(input[1])
                };
                return point;
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
       public static void Main(string[] args)
        {
            int numOfPoints = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            double result = 0;
            double minDistance = double.MaxValue;
            Point closestFistPoint =  null;
            Point closestSecondPoint= null;
            for (int i = 0; i < numOfPoints; i++)
            {
                points.Add(Point.readPoint());
            }
            for (int i = 0; i < points.Count-1; i++)
            {
                for (int j = i+1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];
                    result = Point.CalcDistance(firstPoint, secondPoint);
                    if (result<minDistance)
                    {
                        minDistance = result;
                        closestFistPoint = firstPoint;
                        closestSecondPoint = secondPoint;
                    }
                }
            }
            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine($"({closestFistPoint.x}, {closestFistPoint.y})");
            Console.WriteLine($"({closestSecondPoint.x}, {closestSecondPoint.y})");
        }
    }
}
