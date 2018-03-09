using System;
using System.Text.RegularExpressions;

namespace SeriesOfLetters
{
    public class SeriesOfLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"([a-z]|[A-Z])\1+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (var match in matches)
            {
                int index = input.IndexOf(match.ToString());
                string newText = input.Remove(index, match.ToString().Length-1);
                input = string.Empty;
                input = newText;
                newText = string.Empty;
            }
            Console.WriteLine(input);
            
        }
    }
}
