using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int z = 0; z < num; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
