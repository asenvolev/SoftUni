using System;
using System.Text.RegularExpressions;

namespace Non_DigitCount
{
    public class NonDigitCount
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            string pattern = "[^0-9]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine("Non-digits: " + matches.Count);
        }
    }
}
