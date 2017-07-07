using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mid = 2 * n - 1;
            var leftright = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*',leftright)+new string('\\',1)+ new string('-', mid)+ new string('/', 1)+ new string('*', leftright));
                mid -= 2;
                leftright++;
            }
            mid = n;
            leftright = n / 2;
            for (int i = 0; i < n/3; i++)
            {
                Console.WriteLine(new string('|', 1) + new string('*', leftright) + new string('\\', 1) + new string('*', mid) + new string('/', 1) + new string('*', leftright)+ new string('|', 1));
                mid -= 2;
                leftright++;
            }
            mid = 2 * n - 1;
            leftright = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', leftright) + new string('\\', 1) + new string('*', mid) + new string('/', 1) + new string('-', leftright));
                mid -= 2;
                leftright++;
            }
        }
    }
}
