using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
