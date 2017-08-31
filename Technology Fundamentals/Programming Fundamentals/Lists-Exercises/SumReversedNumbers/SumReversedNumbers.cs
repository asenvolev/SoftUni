using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var reverseParseList = new List<int>();
            var reverseList = new List<char>();
            int finalResult = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                reverseList = current.Reverse().ToList();
                string reversednNum = string.Join("", reverseList);
                int result = int.Parse(reversednNum);
                finalResult += result;
            }
            Console.WriteLine(finalResult);
        }
    }
}
