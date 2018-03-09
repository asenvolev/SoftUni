using System;
using System.Text.RegularExpressions;

namespace MatchCount
{
    public class MatchCount
    {
        public static void Main()
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            
            Console.WriteLine(matches.Count);
        }
    }
}
