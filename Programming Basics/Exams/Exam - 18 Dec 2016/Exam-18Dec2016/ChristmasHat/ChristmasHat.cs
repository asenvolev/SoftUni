using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftright = 2 * n - 1;
            Console.WriteLine(new string('.', leftright) + "/|\\" + new string('.', leftright));
            Console.WriteLine(new string('.', leftright) + "\\|/" + new string('.', leftright));

            for (int i = 0; i < 2*n; i++)
            {
                Console.WriteLine(new string('.', leftright) + "*"+new string('-', i)+"*"+ new string('-', i)+"*" + new string('.', leftright));
                leftright--;
            }
            Console.WriteLine(new string('*', n*4+1));
            for (int i = 0; i < n*2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', n * 4 + 1));
        }
    }
}
