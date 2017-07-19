using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var read = 0;
            var loop = int.Parse(Console.ReadLine());
            for (int i = 0; i < loop; i++)
            {
                read = int.Parse(Console.ReadLine());
                sum += read;
            }
            Console.WriteLine(sum);
        }
    }
}
