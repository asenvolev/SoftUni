using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();
            switch (type)
            {
                default:
                    Console.WriteLine("No such type");
                    break;
                case "face":
                    Console.WriteLine($"{Math.Sqrt(2*Math.Pow(number, 2)):f2}");
                    break;
                case "space":
                    Console.WriteLine($"{Math.Sqrt(3 * Math.Pow(number, 2)):f2}");
                    break;
                case "volume":
                    Console.WriteLine($"{Math.Pow(number, 3):f2}");
                    break;
                case "area":
                    Console.WriteLine($"{6 * Math.Pow(number, 2):f2}");
                    break;
            }
        }
    }
}
