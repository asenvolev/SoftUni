using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class NumberPyramid
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k=1;
            for (int i = 1; i <= n; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    if(z<i-1)
                    {
                        Console.Write(k + " ");
                    }
                    else
                    {
                        Console.WriteLine(k);
                    }
                    k++;
                    if(k==n+1)
                    {
                        break;
                    }
                }
                
                if (k == n+1)
                {
                    break;
                }
            }

        }
    }
}
