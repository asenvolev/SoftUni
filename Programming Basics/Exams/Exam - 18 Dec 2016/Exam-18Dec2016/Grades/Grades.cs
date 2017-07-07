using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var slab = 0.0;
            var sreden = 0.0;
            var dobur = 0.0;
            var otlichen = 0.0;
            var average = 0.0;
            var sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var ocenka = double.Parse(Console.ReadLine());
                if (ocenka <= 2.99)
                {
                    slab++;
                }
                else if (ocenka <= 3.99)
                {
                    sreden++;
                }
                else if (ocenka <= 4.99)
                {
                    dobur++;
                }
                else if (ocenka >= 5.00)
                {
                    otlichen++;
                }
                sum += ocenka;
            }
            Console.WriteLine("Top students: {0:f2}%", (otlichen/n*100));
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", (dobur/n*100));
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", (sreden/n*100));
            Console.WriteLine("Fail: {0:f2}%", (slab/n*100));
            Console.WriteLine("Average: {0:f2}", (sum / n));



        }
    }
}
