
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().ToCharArray();
            var secondNum = int.Parse(Console.ReadLine());

            Array.Reverse(firstNum);
            int cloudNum = 0;
            var result = string.Empty;
            for (int i = 0; i < firstNum.Length; i++)
            {
                int firstCurr = int.Parse(firstNum[i].ToString());
                int currResult = firstCurr * secondNum + cloudNum;
                if (currResult > 9)
                {
                    cloudNum = currResult / 10;
                }
                else
                {
                    cloudNum = 0;
                }
                result = result.Insert(0, (currResult % 10).ToString());

            }
            
            if (cloudNum > 0)
            {
                result = result.Insert(0, cloudNum.ToString());
            }
            if (result.TrimStart('0') == "")
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(result.TrimStart('0'));
            }
        }
    }
}
