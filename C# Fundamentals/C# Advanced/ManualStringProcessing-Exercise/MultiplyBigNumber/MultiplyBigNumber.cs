using System;
using System.Collections.Generic;
using System.Text;

namespace MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var firstNum = new Stack<char>(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            if (secondNum == 0)
            {
                Console.WriteLine("0");
                return;
            }
            int sum = 0;
            var sb = new StringBuilder();
            while (firstNum.Count != 0)
            {
                if (firstNum.Count != 0)
                {
                    sum += secondNum * int.Parse(firstNum.Pop().ToString());
                }
                sb.Insert(0, sum % 10);
                sum /= 10;
            }
            sb.Insert(0, sum);
            if (sb.ToString() == "0")
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine(sb.ToString().TrimStart('0'));
            }
        }
    }
}
