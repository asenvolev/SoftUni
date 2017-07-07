using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var z = 0;
            var sum = 0;
            do
            {
                z = n % 10;
                sum += z;
                n = n / 10;
                z = 0;
            } while (n>0);
            Console.WriteLine(sum);
        }
    }
}
