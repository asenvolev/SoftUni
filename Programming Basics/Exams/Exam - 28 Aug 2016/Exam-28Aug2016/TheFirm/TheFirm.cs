using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    class TheFirm
    {
        static void Main(string[] args)
        {
            var hoursneeded = double.Parse(Console.ReadLine());
            var workdays = double.Parse(Console.ReadLine());
            var overtimeworkers = double.Parse(Console.ReadLine());
            var calcworkhours = (workdays * 8) * 0.9 + workdays * overtimeworkers * 2;
            calcworkhours = Math.Floor(calcworkhours);
            if (hoursneeded<=calcworkhours)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(calcworkhours-hoursneeded));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(hoursneeded - calcworkhours));
            }

        }
    }
}
