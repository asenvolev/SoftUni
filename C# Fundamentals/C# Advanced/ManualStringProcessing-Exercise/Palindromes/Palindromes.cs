using System;
using System.Collections.Generic;
using System.Text;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '!', '?', ',', '.' },
                StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            var palindromes = new SortedSet<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string currWord = input[i];
                if (currWord.Length%2 ==0)
                {
                    string firstPart = currWord.Substring(0,currWord.Length/2);
                    var secondPart = currWord.Substring(currWord.Length / 2, currWord.Length/2).ToCharArray();
                    Array.Reverse(secondPart);
                    string reversed = new string(secondPart);
                    if (firstPart.Equals(reversed.ToString()))
                    {
                        palindromes.Add(currWord);
                    }
                }
                if (currWord.Length % 2 == 1)
                {
                    string firstPart = currWord.Substring(0, currWord.Length / 2);
                    var secondPart = currWord.Substring(currWord.Length / 2 +1, currWord.Length / 2).ToCharArray();
                    Array.Reverse(secondPart);
                    string reversed = new string(secondPart);
                    if (firstPart.Equals(reversed.ToString()))
                    {
                        palindromes.Add(currWord);
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", palindromes)}]");
        }
    }
}
