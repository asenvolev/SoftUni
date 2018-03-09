using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    public class MatchFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string pattern = "^([A-Z]{1}[a-z]+) ([A-Z]{1}[a-z]+)";
            while (input != "end")
            {
                Regex regex = new Regex(pattern);
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
