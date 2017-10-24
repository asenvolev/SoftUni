using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            var firstNum = Console.ReadLine().ToCharArray();
            var secondNum = Console.ReadLine().ToCharArray();

            Array.Reverse(firstNum);
            Array.Reverse(secondNum);
            var minVal = Math.Min(firstNum.Length, secondNum.Length);
            int cloudNum = 0;
            var result = string.Empty;
            for (int i = 0; i < minVal; i++)
            {
                int firstCurr = int.Parse(firstNum[i].ToString());
                int secondCurr = int.Parse(secondNum[i].ToString());
                int currResult = firstCurr + secondCurr + cloudNum;
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
            if (firstNum.Length > secondNum.Length)
            {
                for (int i = minVal; i < firstNum.Length; i++)
                {
                    int firstCurr = int.Parse(firstNum[i].ToString());
                    int currResult = firstCurr + cloudNum;
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
            }
            if (firstNum.Length < secondNum.Length)
            {
                for (int i = minVal; i < secondNum.Length; i++)
                {
                    int secondCurr = int.Parse(secondNum[i].ToString());
                    int currResult = secondCurr + cloudNum;
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
            }
            if (cloudNum > 0)
            {
                result = result.Insert(0, cloudNum.ToString());
            }
            Console.WriteLine(result.TrimStart('0'));
        }
    }
}
