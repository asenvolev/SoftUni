using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeTwo
{
    class TakeTwo
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine().Split().Distinct().Select(int.Parse).Where(x=>x>=10 && x<=20).Take(2)));
        }
    }
}
