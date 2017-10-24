using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class ExtractSentencesByKeyword
    {
        static void Main(string[] args)
        {
            var wordtosearch = Console.ReadLine();
            var input = Console.ReadLine().Split('.','!','?').Select(x=> x.Trim(' '));
            string patern = "\\b"+ wordtosearch +"\\b";
            var regex = new Regex(patern);
            foreach (var sentence in input)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }
            }
        }
    }
}
