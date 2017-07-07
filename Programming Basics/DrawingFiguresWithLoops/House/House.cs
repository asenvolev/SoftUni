using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int starsEven = 2;
            if (n % 2 == 0)
            {
                int dasheshCount = (n - 2) / 2;
                for (int i = 0; i < (n - n / 2) - 1; i++)
                {
                    Console.WriteLine(new string('-', dasheshCount) + new string('*', starsEven) + new string('-', dasheshCount));
                    dasheshCount--;
                    starsEven += 2;

                }
            }
            else
            {
                int starsOdd = 1;
                int dasheshOdd = (n / 2);
                for (int i = 0; i < (n - n / 2) - 1; i++)
                {
                    Console.WriteLine(new string('-', dasheshOdd) + new string('*', starsOdd) + new string('-', dasheshOdd));
                    dasheshOdd--;
                    starsOdd += 2;

                }
            }

            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}
