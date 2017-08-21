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
            int num = int.Parse(Console.ReadLine());
            char letter = (char)('a' + num-1);


            for (char i = 'a'; i <= letter; i++)
            {
                for (char j = 'a'; j <= letter; j++)
                {
                    for (char k = 'a'; k <= letter; k++)
                    {
                        Console.Write("{0}{1}{2} ", i, j, k);

                    }
                }
            }
            
        }
    }
}
