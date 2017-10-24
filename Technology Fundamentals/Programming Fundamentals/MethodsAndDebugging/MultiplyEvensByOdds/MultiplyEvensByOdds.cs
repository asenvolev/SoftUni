using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            evenMulOdd(number, evenSum, oddSum);
            
        }

        private static void evenMulOdd(int number, int evenSum, int oddSum)
        {
            while (number != 0)
            {
                int temp = number % 10;
                if (temp % 2 == 0)
                {
                    evenSum += temp;
                }
                else
                {
                    oddSum += temp;
                }
                number /= 10;
            }

            Console.WriteLine(oddSum * evenSum);
        }
    }
}
