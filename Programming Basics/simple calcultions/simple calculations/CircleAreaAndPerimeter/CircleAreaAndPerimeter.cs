using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var S = Math.PI * r*r;
            var P = 2 * Math.PI * r;
            Console.WriteLine("Area = {0}\nPerimeter = {1}", S, P);
        }
    }
}
