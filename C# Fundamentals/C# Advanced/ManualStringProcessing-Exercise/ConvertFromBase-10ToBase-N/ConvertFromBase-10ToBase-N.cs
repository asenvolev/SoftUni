using System;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ConvertFromBase_10ToBase_N
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            BigInteger baseToConvert = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            var sb = new StringBuilder();
            while (number>0)
            {
                BigInteger temp = number % baseToConvert;
                number /= baseToConvert;
                sb.Insert(0,temp);
            }
            Console.WriteLine(sb);
        }
    }
}
