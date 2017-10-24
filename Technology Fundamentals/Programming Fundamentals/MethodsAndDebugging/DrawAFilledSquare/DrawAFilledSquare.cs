using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class DrawAFilledSquare
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            printLine(number);
            int count = 0;
            for (int i = 0; i < number-2; i++)
            {
                printInside(number);
            }
            printLine(number);
        }

        private static void printInside(int number)
        {
            Console.Write("-");
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void printLine(int number)
        {
            Console.WriteLine(new string('-',2*number));
        }
    }
}
