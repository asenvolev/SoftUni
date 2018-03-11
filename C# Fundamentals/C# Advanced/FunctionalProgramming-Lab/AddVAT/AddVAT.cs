using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddVAT
{
    class AddVAT
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x=>x*=1.2)
                .ToList()
                .ForEach(n=>Console.WriteLine($"{n:f2}"));

        }
    }
}
