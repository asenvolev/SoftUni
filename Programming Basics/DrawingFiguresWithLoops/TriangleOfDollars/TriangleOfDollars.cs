using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int z = 0; z < i; z++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
