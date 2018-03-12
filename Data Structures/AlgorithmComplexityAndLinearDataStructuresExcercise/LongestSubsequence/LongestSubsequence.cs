using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSubsequence
{
    public class LongestSubsequence
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            var longestSubseq = new List<int>();

            int currCounter = 1;
            int currNumber = 0;

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i-1])
                {
                    currCounter++;
                    currNumber = input[i];
                }
                else
                {
                    if (currCounter>longestSubseq.Count())
                    {
                        longestSubseq.Clear();
                        longestSubseq.AddRange(Enumerable.Repeat(currNumber, currCounter));
                    }
                    currCounter = 1;
                    currNumber = 0;
                }
            }
            if (currCounter > longestSubseq.Count())
            {
                longestSubseq.Clear();
                longestSubseq.AddRange(Enumerable.Repeat(currNumber, currCounter));
            }
            Console.WriteLine(string.Join(" ",longestSubseq));
        }
    }
}
