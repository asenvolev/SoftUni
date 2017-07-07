using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = double.Parse(Console.ReadLine());
            var years = year - 1800;
            var howold = 18;
            var sum = 0.0;
            for (int i = 0; i <= years; i++)
            {
                if(i%2==0)
                {
                    sum += 12000;
                }
                else
                {
                    sum += 12000 + 50 * howold;
                }
                howold++;
            }
            if(money>=sum)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.",money-sum);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.",sum-money);
            }
        }
    }
}
