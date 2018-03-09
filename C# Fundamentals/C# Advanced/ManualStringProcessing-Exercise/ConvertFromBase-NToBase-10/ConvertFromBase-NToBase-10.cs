using System;
using System.Numerics;

namespace ConvertFromBase_NToBase_10
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            BigInteger N = int.Parse(input[0]);
            var number = input[1].ToCharArray();
            Array.Reverse(number);
            BigInteger result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int curr = int.Parse(number[i].ToString());
                BigInteger convert = (BigInteger)(curr * Power(N, i));
                result += convert;
            }
            Console.WriteLine(result);

        }

        public static BigInteger Power(BigInteger n, int pow)
        {
            BigInteger temp = 1;

            for (int i = 0; i < pow; i++)
            {
                temp *= n;
            }
            return temp;
        }
    }
}
