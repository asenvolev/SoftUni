using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            double bonus = 0;
            if (num1 <=100)
            {
                bonus = 5;
            }
            if (num1>100 && num1<=1000)
            {
                bonus = num1*0.2;
            }
            if (num1>1000)
            {
                bonus = num1 * 0.1;
            }
            if (num1%2==0)
            {
                bonus += 1;
            }
            else if (num1%10==5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num1 + bonus);
        }
    }
}
