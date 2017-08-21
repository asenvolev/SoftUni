using System;
using System.Linq;

namespace LargestCommonEnd
{
    internal class LargestCommonEnd
    {
        private static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ').ToArray();
            string[] second = Console.ReadLine().Split(' ').ToArray();
            int shortArr = Math.Min(first.Length, second.Length);
            int leftToRightCount = 0;
            leftToRightCount = equalWordsCheck(first, second, leftToRightCount, shortArr);
            Array.Reverse(first);
            Array.Reverse(second);
            second.Reverse();
            int rightToLeftCount = 0;
            rightToLeftCount = equalWordsCheck(first, second, rightToLeftCount, shortArr);

            Console.WriteLine(Math.Max(leftToRightCount, rightToLeftCount));
        }

        public static int equalWordsCheck(string[] first, string[] second, int Count, int shortArr)
        {
            for (int i = 0; i < shortArr; i++)
            {
                if (first[i] == second[i])
                {
                    Count++;
                }
                else
                {
                    break;
                }
            }
            return Count;
        }
    }
}