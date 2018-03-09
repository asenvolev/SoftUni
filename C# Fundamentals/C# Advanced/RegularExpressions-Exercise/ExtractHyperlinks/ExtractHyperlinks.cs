using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var text = new StringBuilder();
            while (input != "END")
            {
                text.Append(input).Append(" ");

                input = Console.ReadLine();
            }
            string allText = text.ToString();
            string pattern = @"<a\s+[^>]*href\s*=\s*(.*?)>";
            var regex = new Regex(pattern, RegexOptions.Multiline);
            MatchCollection matches = regex.Matches(allText);
            foreach (Match match in matches)
            {
                string matchToPrint = match.Groups[1].ToString().Trim();
                if (matchToPrint[0] == '"')
                {
                    Console.WriteLine(matchToPrint.Split(new[] { '\"' },
                        StringSplitOptions.RemoveEmptyEntries).First());
                }
                else if (matchToPrint[0] == '\'')
                {
                    Console.WriteLine(matchToPrint.Split(new[] { '\'' },
                        StringSplitOptions.RemoveEmptyEntries).First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(matchToPrint, @"\s+").First());
                }
            }
        }
    }
}
