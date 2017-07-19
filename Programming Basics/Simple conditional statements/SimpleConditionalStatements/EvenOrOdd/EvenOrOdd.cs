using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            var chislo = double.Parse(Console.ReadLine());
            if(chislo % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
