using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal power = decimal.Parse(Console.ReadLine());
            Console.WriteLine(calculatePower(number, power));
        }

        private static decimal calculatePower(decimal number, decimal power)
        {
            decimal temporary = number;
            for (int i = 0; i < power - 1; i++)
            {
                number *= temporary;
            }
            return number;
        }
    }
}
