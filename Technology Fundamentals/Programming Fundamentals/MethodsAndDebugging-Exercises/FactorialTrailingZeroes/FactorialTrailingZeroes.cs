using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            BigInteger fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact *= i;
            }
            int count = 0;
            int check = 0;
            while (check ==0)
            {
                check = (int)(fact % 10);
                fact /= 10;
                count++;
            }
            Console.WriteLine(count--);
        }
    }
}
