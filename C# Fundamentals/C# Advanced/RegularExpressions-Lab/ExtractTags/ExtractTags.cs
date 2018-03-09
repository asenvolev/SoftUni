using System;
using System.Text.RegularExpressions;

namespace ExtractTags
{
    public class ExtractTags
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"<.+?>";
            
            while (input != "END")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                matches = regex.Matches(input);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }

        }
    }
}
