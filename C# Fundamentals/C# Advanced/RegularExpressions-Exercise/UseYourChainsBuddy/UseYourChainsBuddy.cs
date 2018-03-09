using System;
using System.Text.RegularExpressions;

namespace UseYourChainsBuddy
{
    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = @"<p>(.+?)<\/p>";
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                string sentence = match.Groups[1].Value;
                string replaced = Regex.Replace(sentence, @"[\WA-Z]"," ");
                replaced = Regex.Replace(replaced, @"\s+", " ");

                foreach (var character in replaced)
                {
                    if (character <='m' && character >='a')
                    {
                        Console.Write((char)(character + 13)); 
                    }
                    else if (character >='n' && character <= 'z')
                    {
                        Console.Write((char)(character - 13));
                    }
                    else
                    {
                        Console.Write(character);
                    }
                }
            }
        }
    }
}
