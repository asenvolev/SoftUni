using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    class EvenPowersOf2
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 2.0;
            

            for (int i = 0; i <= n; i+=2)
            {
                num = Math.Pow(2, i);
                Console.WriteLine(num);
            }
        }
    }
}
