using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            var loop = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            for (int i = 0; i < loop; i++)
            {
                var read = int.Parse(Console.ReadLine());
                if(read > max )
                {
                    max = read;
                }
            }
            Console.WriteLine(max);
        }
    }
}
