using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var mid = num * 3;
            Console.WriteLine(new string('.', num) + new string('*', mid) + new string('.', num));
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(new string('.', num-i) + new string('*', 1) + new string('.', mid) + new string('*', 1) + new string('.', num-i));
                mid+=2;
            }
            Console.WriteLine(new string('*', num*5));
            var q = 2 * num + 1;
            mid -= 2;
            for (int j = q-1; j > -1; j--)
            {
                
                if (j==0)
                {
                    Console.WriteLine(new string('.', q - j) + new string('*', 1) + new string('*', mid) + new string('*', 1) + new string('.', q - j));
                }
                else
                {
                    Console.WriteLine(new string('.', q - j) + new string('*', 1) + new string('.', mid) + new string('*', 1) + new string('.', q - j));
                    mid -= 2;
                }

            }
        }
    }
}
