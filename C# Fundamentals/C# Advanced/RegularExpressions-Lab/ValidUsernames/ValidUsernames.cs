using System;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"^[\w-]{3,16}$";

            while (input != "END")
            {
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    if (input!=string.Empty)
                    {
                        Console.WriteLine("invalid");
                    }
                    
                }
                input = Console.ReadLine();
            }
        }
    }
}
