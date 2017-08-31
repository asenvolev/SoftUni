using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var currentSeq = new List<int>();
            var longestSeq = new List<int>();
            currentSeq.Add(input[0]);
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == currentSeq[0])
                {
                    currentSeq.Add(input[i]);
                }
                else
                {
                    if (currentSeq.Count>longestSeq.Count)
                    {
                        longestSeq.Clear();
                        longestSeq.AddRange(currentSeq);
                    }
                    currentSeq.Clear();
                    currentSeq.Add(input[i]);
                }
            }
            if (currentSeq.Count > longestSeq.Count)
            {
                longestSeq.Clear();
                longestSeq.AddRange(currentSeq);
            }
            
            Console.WriteLine(string.Join(" ", longestSeq));

        }
    }
}
