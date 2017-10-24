using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger N = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            var result = string.Empty;

            while (number > 0)
            {
                BigInteger temp = number % N;
                number /= N;

                result+= temp.ToString();
            }
            var reverseRes = result.ToCharArray();
            Array.Reverse(reverseRes);

            Console.WriteLine(reverseRes);
            
        }
    }
}
