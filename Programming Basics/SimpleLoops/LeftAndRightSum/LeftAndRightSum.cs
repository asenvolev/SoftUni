using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;
            for (int i = 1; i <= n; i++)
            {
                var read = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    evensum+= read;
                }
                if (i%2==1)
                {
                    oddsum += read;
                }
            }
            if (evensum==oddsum)
            {
                Console.WriteLine("Yes, sum = "+oddsum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(oddsum-evensum));
            }
        }
    }
}
