using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var broihrizantemi = int.Parse(Console.ReadLine());
            var broirozi = int.Parse(Console.ReadLine());
            var broilaleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var holyday = Console.ReadLine().ToLower();
            var cenahrizantemi = 0.0;
            var cenarozi = 0.0;
            var cenalaleta = 0.0;
            var buketdiscount = 1.0;
            var otstupka2 = 1.0;
            var aranjirane = 2;
            if (season == "spring" || season == "summer")
            {
                cenahrizantemi = 2;
                cenarozi = 4.10;
                cenalaleta = 2.50;
                if (holyday == "y")
                {
                    cenahrizantemi *=1.15;
                    cenarozi *= 1.15;
                    cenalaleta *= 1.15;
                }
                if (season == "spring" && broilaleta > 7)
                {
                    buketdiscount = 0.95;
                }
                if (broihrizantemi + broilaleta + broirozi > 20)
                {
                    otstupka2 = 1.2;
                }
            }
            else if (season == "autumn" || season == "winter")
            {
                cenahrizantemi = 3.75;
                cenarozi = 4.50;
                cenalaleta = 4.15;
                if (holyday == "y")
                {
                    cenahrizantemi *= 1.15;
                    cenarozi *= 1.15;
                    cenalaleta *= 1.15;
                }
                if (season == "winter" && broirozi >= 10)
                {
                    buketdiscount = 0.90;
                }
                if (broihrizantemi + broilaleta + broirozi > 20)
                {
                    otstupka2 = 0.8;
                }
            }
            var sumall = ((broihrizantemi * cenahrizantemi + broilaleta * cenalaleta + broirozi * cenarozi) * buketdiscount) * otstupka2 +aranjirane;
            Console.WriteLine("{0:f2}",sumall);

        }
    }
}
