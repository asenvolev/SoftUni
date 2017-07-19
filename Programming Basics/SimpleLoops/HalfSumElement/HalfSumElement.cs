using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var loop = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var sum = 0;
            var flag=0;
            for (int i = 0; i < loop; i++)
            {
                var read = int.Parse(Console.ReadLine());
                if (read > max)
                {
                    max = read;
                    sum += read;
                }
                else
                {
                    sum += read;
                }
                
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes\nSum = " + max);
            }
            else
            {
                Console.WriteLine("No\nDiff = {0}", Math.Abs(max - sum));
            }
            
        }
    }
}
