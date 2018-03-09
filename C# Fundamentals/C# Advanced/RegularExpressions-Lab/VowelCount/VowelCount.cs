using System;
using System.Text.RegularExpressions;

namespace VowelCount
{
    public class VowelCount
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = "[AEIOUYaeiouy]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            Console.WriteLine("Vowels: "+matches.Count);
        }
    }
}
