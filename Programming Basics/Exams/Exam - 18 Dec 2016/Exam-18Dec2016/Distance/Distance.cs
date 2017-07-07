using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var speed1 = int.Parse(Console.ReadLine());
            var min1 = double.Parse(Console.ReadLine());
            var min2 = double.Parse(Console.ReadLine());
            var min3 = double.Parse(Console.ReadLine());
            var speed2 = speed1*1.1;
            var speed3 = speed2*0.95;
            double hours1 = min1 / 60;
            double hours2 = min2 / 60;
            double hours3 = min3 / 60;
            var atall = speed1 * hours1 + speed2 * hours2 + speed3 * hours3;
            Console.WriteLine("{0:f2}",atall);
        }
    }
}
