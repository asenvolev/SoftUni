using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfCircles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Circle first = new Circle
            {
                X = int.Parse(input[0]),
                Y = int.Parse(input[1]),
                Radius = int.Parse(input[2]),
            };
            string[] secondInput = Console.ReadLine().Split();
            Circle second = new Circle
            {
                X = int.Parse(secondInput[0]),
                Y = int.Parse(secondInput[1]),
                Radius = int.Parse(secondInput[2]),
            };
            double distance = CalcDistance(first, second);
            if (distance>first.Radius+second.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }

        private static double CalcDistance(Circle first, Circle second)
        {
            double diffX = Math.Abs(first.X - second.X);
            double diffY = Math.Abs(first.Y - second.Y);
            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);
            return Math.Sqrt(powX + powY);
        }
    }
}
