using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(people/capacity));
        }
    }
}
