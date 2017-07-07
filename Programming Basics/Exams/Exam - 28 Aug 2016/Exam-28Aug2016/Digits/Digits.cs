using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num1 = n / 100;
            var num3 = n % 10;
            var num2 = (n - (num1 * 100) - num3)/10;
            var rows = num1 + num2;
            var columns = num1 + num3;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (n%5==0)
                    {
                        n -= num1;
                    }
                    else if (n%3==0)
                    {
                        n -= num2;
                    }
                    else
                    {
                        n += num3;
                    }
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
