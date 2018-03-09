using System;
using System.Text.RegularExpressions;

namespace ValidTime
{
    public class ValidTime
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([0][0-9]|[1][0-2]):[0-5][0-9]:[0-5][0-9] [A|P]M";

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
                    if (input != string.Empty)
                    {
                        Console.WriteLine("invalid");
                    }

                }
                input = Console.ReadLine();
            }
        }
    }
}
