using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if(n<2)
            {
                Console.WriteLine("Not Prime");
            }
            else if(n==2||n==3)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Not Prime");
                    }
                    else
                    {
                        Console.WriteLine("Prime");
                    }
                }
            }
        }
    }
}
