using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(x=>"Sir "+x)));
        }
    }
}
