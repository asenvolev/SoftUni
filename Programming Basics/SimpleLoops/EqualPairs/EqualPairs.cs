using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            bool areEqual = true;
            int number = int.Parse(Console.ReadLine());
            int firstNumbersSum = 0;
            int maxDiff = int.MaxValue;
            int[] array = new int[number];
            for (int i = 0; i < number; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int currentSum = firstNumber + secondNumber;
                if (currentSum < maxDiff)
                {
                    array[i] = firstNumber + secondNumber;

                }
                if (i == 0)
                {
                    firstNumbersSum = currentSum;
                }
                else
                {
                    if (currentSum != firstNumbersSum)
                    {
                        areEqual = false;
                    }
                }
            }
            if (areEqual)
            {
                Console.WriteLine("Yes, value={0}", firstNumbersSum);
            }
            else
            {
                int maxd = int.MinValue;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    int current = Math.Abs(array[i] - array[i + 1]);
                    if (current > maxd)
                    {
                        maxd = current;
                    }
                }
                Console.WriteLine("No, maxdiff={0}", maxd);
            }
        }
    }
}