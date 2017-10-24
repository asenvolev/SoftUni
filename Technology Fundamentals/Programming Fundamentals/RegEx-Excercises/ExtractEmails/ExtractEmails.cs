using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var regex = new Regex(@"^(([^\/<>()\[\]\\.,;:\s@""]+(\.[^<>()\[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))");
            var result = new List<string>();
            foreach (var word in input)
            {
                var matches = regex.Matches(word);
                foreach (Match item in matches)
                {
                    if (!result.Contains(item.ToString()))
                    {
                        if (!(item.ToString().StartsWith("_") || item.ToString().StartsWith("-")))
                        {
                            result.Add(item.ToString());
                        }
                    }
                }

            }
            Console.WriteLine(string.Join("\n", result));
            
        }
    }
}
