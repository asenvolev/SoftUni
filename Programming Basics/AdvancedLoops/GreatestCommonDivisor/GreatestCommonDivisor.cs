using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var b = long.Parse(Console.ReadLine());
            
            while (b!=0)
            {
                var oldA = b;
                b = a % b;
                a = oldA;
            }
            Console.WriteLine(a);
        }
    }
}
