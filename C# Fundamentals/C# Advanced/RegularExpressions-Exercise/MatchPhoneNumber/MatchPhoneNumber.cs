using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = @"\+359( |-)\d\1\d{3}\1\d{4}$";
            while (input != "end")
            {
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
