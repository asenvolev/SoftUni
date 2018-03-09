using System;
using System.Text.RegularExpressions;

namespace SentenceExtractor
{
    public class SentenceExtractor
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            string pattern = $@"([a-zA-Z0-9 ]+\b{word}\b\s*.*?[?!.])";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
