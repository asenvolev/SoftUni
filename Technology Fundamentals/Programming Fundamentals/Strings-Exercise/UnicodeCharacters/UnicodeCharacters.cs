using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine().ToCharArray();
            var result = new List<string>();
            var build = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int curr = input[i];
                string convert = curr.ToString("x");
                build.Append("\\u00"+convert);
            }
            Console.WriteLine(build);
        }
    }
}
