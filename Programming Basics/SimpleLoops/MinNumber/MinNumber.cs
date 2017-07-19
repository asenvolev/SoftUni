using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            var loop = int.Parse(Console.ReadLine());
            var min = int.MaxValue;
            for (int i = 0; i < loop; i++)
            {
                var read = int.Parse(Console.ReadLine());
                if (read < min)
                {
                    min = read;
                }
            }
            Console.WriteLine(min);
        }
    }
}
