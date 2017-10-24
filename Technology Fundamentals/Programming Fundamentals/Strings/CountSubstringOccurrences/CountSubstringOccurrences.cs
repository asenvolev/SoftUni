using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var wordToCount = Console.ReadLine().ToLower();
            int index = 0;
            int counter = 0;
            while (true)
            {
                var word = input.IndexOf(wordToCount, index);
                if (word>=0)
                {
                    counter++;
                    index=word+1;
                    word = 0;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
