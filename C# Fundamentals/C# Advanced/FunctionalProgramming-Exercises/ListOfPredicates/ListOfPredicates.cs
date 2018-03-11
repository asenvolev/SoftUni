using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPredicates
{
    class ListOfPredicates
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
            
            for (int i = 1; i <= range; i++)
            {
                bool passed = true;
                foreach (var divider in dividers)
                {
                    if (i%divider==0)
                    {
                        continue;
                    }
                    else
                    {
                        passed = false;
                        break;
                    }
                }
                if (passed)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
