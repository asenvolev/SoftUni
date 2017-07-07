using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == num - 1)
                {
                    Console.WriteLine(new string('*', num*2) + new string(' ', num) + new string('*', num * 2));
                }
                else
                {
                    Console.Write("*" + new string('/', num*2 - 2) + "*");
                    if(num%2 == 0)
                    {
                        if (i == (num - 2) / 2)
                        {
                            Console.Write(new string('|', num));
                        }
                        else
                        {
                            Console.Write(new string(' ', num));
                        }
                    }
                    else
                    {
                        if (i == (num - 2) / 2 +1)
                        {
                            Console.Write(new string('|', num));
                        }
                        else
                        {
                            Console.Write(new string(' ', num));
                        }
                    }
                    Console.Write("*" + new string('/', num * 2 - 2) + "*");
                    Console.WriteLine();
                }
                
            }
        }
    }
}
