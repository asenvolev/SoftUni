using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
