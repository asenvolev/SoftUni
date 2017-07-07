using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var kvadmetri = double.Parse(Console.ReadLine());
            var grozdenakvadm = double.Parse(Console.ReadLine());
            var nyjnilitri = double.Parse(Console.ReadLine());
            var broirabotnici = double.Parse(Console.ReadLine());
            var grozdekg = 0.4 * kvadmetri * grozdenakvadm;
            var totalwine = grozdekg / 2.5;
            var litersleft = 0.0;
            if(totalwine >= nyjnilitri)
            {
                litersleft = totalwine - nyjnilitri;
                var LperP = litersleft / broirabotnici;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.",Math.Floor(totalwine),Math.Ceiling(litersleft),Math.Ceiling(LperP));
            }
            else
            {
                litersleft = Math.Abs(totalwine - nyjnilitri);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(litersleft));
            }

        }
    }
}
