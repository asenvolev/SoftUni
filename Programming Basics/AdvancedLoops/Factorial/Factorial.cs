using System;
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
            var n = int.Parse(Console.ReadLine());
            var z = n;
            var sum = 1;
            for (int i = 0; i < n; i++)
            {
                sum *= z;
                z--; 
            }
            Console.WriteLine(sum);
        }
    }
}
