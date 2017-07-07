using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == num-1)
                {
                    Console.Write("+ ");
                    for (int j = 0; j < num-2; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("| ");
                    for (int j = 0; j < num - 2; j++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
            }
        }
    }
}
