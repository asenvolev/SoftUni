using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            printUpperHalf(number);
            printMiddle(number);
            printBottomHalf(number);
            
            
        }

        private static void printBottomHalf(int number)
        {
            for (int z = number - 1; z > 0; z--)
            {
                for (int x = 1; x <= z; x++)
                {
                    Console.Write(x + " ");
                }

                Console.WriteLine();
            }
        }

        private static void printMiddle(int number)
        {
            for (int i = 1; i <= number ; i++)
            {
                Console.Write(i+" ");
            }

            Console.WriteLine();
        }

        private static void printUpperHalf(int number)
        {
            for (int i = 1; i <= number - 1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
