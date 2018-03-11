using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class PredicateForNames
    {
        static void Main(string[] args)
        {
            var length = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join("\n",Console.ReadLine().Split().ToList().Where(x=>x.Length<=length)));
        }
    }
}
