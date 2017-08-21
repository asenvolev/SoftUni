using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            byte a = byte.Parse(Console.ReadLine());
            byte b = byte.Parse(Console.ReadLine());
            double c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
            int perimeter = 2 * a + 2 * b;
            int S = a * b;
            Console.WriteLine($"{perimeter}\n{S}\n{c}");
        }
    }
}
