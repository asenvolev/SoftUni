using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mid = 0;
            var right = 2 * n - 2;
            var left = 3 * n;
            
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(new string('-',left)+new string('*',1)+new string('-',mid)+new string('*',1)+new string('-',right));
                    right--;
                    mid++;
                }
                right++;
                mid--;
                for (int i = 0; i < n/2; i++)
                {
                    Console.WriteLine(new string('*', left) + new string('*', 1) + new string('-', mid) + new string('*', 1) + new string('-', right));
                }
                for (int i = 0; i < n / 2; i++)
                {
                    if (i==n/2-1)
                    {
                        Console.WriteLine(new string('-', left) + new string('*', 1) + new string('*', mid) + new string('*', 1) + new string('-', right));
                    }
                    else
                    {
                        Console.WriteLine(new string('-', left) + new string('*', 1) + new string('-', mid) + new string('*', 1) + new string('-', right));
                        left--;
                        right--;
                        mid += 2;
                    }
                }
            

        }
    }
}
