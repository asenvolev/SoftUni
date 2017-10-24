using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' ','\n','\r','!','?',',','.','\"','\'' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();
            var palindromes = new List<string>();
            for (int j = 0; j < input.Length; j++)
            {
                var currentWord = input[j];
                StringBuilder builder = new StringBuilder(currentWord.Length);
                
                for (int i = currentWord.Length - 1; i >= 0; i--)
                {
                    builder.Append(currentWord[i]);
                }
                if (builder.ToString() == currentWord)
                {
                    palindromes.Add(currentWord);
                }
            }
            var sortedPalindromes = palindromes.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sortedPalindromes));
        }
    }
}
