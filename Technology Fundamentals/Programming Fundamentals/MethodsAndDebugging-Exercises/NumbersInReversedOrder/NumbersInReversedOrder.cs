using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            string reversedNum = num.ToString();

            string output = "";
            for (int i = reversedNum.Length - 1; i >= 0; i--)
            {
                output += reversedNum[i];
            }

            Console.WriteLine(output);
        }


    }
}
