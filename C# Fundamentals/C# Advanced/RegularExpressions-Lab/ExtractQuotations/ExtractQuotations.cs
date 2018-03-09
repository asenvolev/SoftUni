using System;
using System.Text.RegularExpressions;

namespace ExtractQuotations
{
    public class ExtractQuotations
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"'.+?'|"".+?""";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString().Trim(new[] { '\'','"'}));
            }
        }
    }
}
