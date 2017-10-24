using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            switch (type)
            {
                default:
                    Console.WriteLine("No such type");
                    break;
                case "triangle":
                    double sideTRI = double.Parse(Console.ReadLine());
                    double heightTRI = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{sideTRI*heightTRI/2:f2}");
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRec = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{width * heightRec :f2}");
                    break;
                case "square":
                    double side = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{side * side:f2}");
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Math.PI*radius*radius:f2}");
                    break;
            }
        }
    }
}
