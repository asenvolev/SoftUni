using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)([a-z]+|\d+)(\d+|\w+|\.+|-+)([a-z]+|\d+)\@[a-z]+\-?[a-z]+\.[a-z]+(\.[a-z]+)?";
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                string matchString = match.ToString();
                if (!(matchString.StartsWith("_") ||
                    matchString.StartsWith("-") ||
                    matchString.StartsWith(".") ||
                    matchString.EndsWith("_") ||
                    matchString.EndsWith("-") ||
                    matchString.EndsWith(".")))
                {
                    Console.WriteLine(matchString);
                }
            }
        }
    }
}
