using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (j < n)
                    {
                        Console.Write(j + " ");
                    }
                    else
                    {
                        if (i==1)
                        {
                            Console.WriteLine(j);
                        }
                        else
                        {
                            for (int z = j; z >1+ i; z--)
                            {
                                if (z > i + 1)
                                {
                                    Console.Write(z + " ");
                                }
                                else if (z==i+2)
                                {
                                    Console.WriteLine(z);
                                }
                            }
                            
                        }
                    }
                }
                
                
            }
        }
    }
}
