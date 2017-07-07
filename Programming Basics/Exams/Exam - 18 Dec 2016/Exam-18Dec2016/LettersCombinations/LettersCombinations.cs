using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCombinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            var let1 = char.Parse(Console.ReadLine());
            var let2 = char.Parse(Console.ReadLine());
            var let3 = char.Parse(Console.ReadLine());
            var count = 0;

            for (char i = let1; i <= let2; i++)
            {
                for (char j = let1; j <= let2; j++)
                {
                    for (char k = let1; k <= let2; k++)
                    {
                        if (i == let3 || j == let3 || k == let3)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ", i, j, k);
                            count++;
                        }
                        
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
