using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;
            if(type=="square")
            {
                var squareA = double.Parse(Console.ReadLine());
                area = squareA * squareA;
            }
            if (type == "rectangle")
            {
                var recA = double.Parse(Console.ReadLine());
                var recB = double.Parse(Console.ReadLine());
                area = recA * recB;
            }
            if (type == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                area = Math.PI*Math.Pow(radius,2);
            }
            if (type == "triangle")
            {
                var A = double.Parse(Console.ReadLine());
                var hA = double.Parse(Console.ReadLine());
                area = A*hA/2;
            }
            Console.WriteLine(area);
        }
    }
}
