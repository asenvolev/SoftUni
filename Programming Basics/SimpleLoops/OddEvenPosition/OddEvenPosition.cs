using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var loop = int.Parse(Console.ReadLine());
            var oddmax = double.MinValue;
            var oddmin = double.MaxValue;
            var oddsum = 0.0;
            var evenmax = double.MinValue;
            var evenmin = double.MaxValue;
            var evensum = 0.0;
            for (int i = 1; i <= loop; i++)
            {
                var read = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    if (read > evenmax)
                    {
                        evenmax = read;
                        evensum += read;
                    }
                    else
                    {
                        evensum += read;
                    }
                    if (read < evenmin)
                    {
                        evenmin = read;

                    }
                }
                else 
                {
                    if (read > oddmax)
                    {
                        oddmax = read;
                        oddsum += read;
                    }
                    else
                    {
                        oddsum += read;
                    }
                    if (read < oddmin)
                    {
                        oddmin = read;
                    }
                }

            }
            if (loop == 0)
            {
                Console.WriteLine("OddSum={0},\nOddMin=No,\nOddMax=No,\nEvenSum={1},\nEvenMin=No,\nEvenMax=No", oddsum, evensum);
            }
            else if (loop == 1)
            {
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2},\nEvenSum={3},\nEvenMin=No,\nEvenMax=No", oddsum, oddmin, oddmax, evensum);

            }
            else
            {
                Console.WriteLine("OddSum={0},\nOddMin={1},\nOddMax={2},\nEvenSum={3},\nEvenMin={4},\nEvenMax={5}", oddsum, oddmin, oddmax, evensum, evenmin, evenmax);
            }

        }
    }
}
