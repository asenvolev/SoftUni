using System;
using System.Collections.Generic;
using System.Text;

namespace SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = new Stack<char>(Console.ReadLine());
            var secondNum = new Stack<char>(Console.ReadLine());
            int sum = 0;
            var sb = new StringBuilder();
            while (firstNum.Count!=0 || secondNum.Count!=0)
            {
                sum /= 10;
                if (firstNum.Count!=0)
                {
                    sum += int.Parse(firstNum.Pop().ToString());
                }
                if (secondNum.Count!=0)
                {
                    sum += int.Parse(secondNum.Pop().ToString());
                }
                sb.Insert(0, sum % 10);
            }
            sb.Insert(0, sum / 10);

            Console.WriteLine(sb.ToString().TrimStart('0'));
        }
    }
}
