using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var weekends = int.Parse(Console.ReadLine());
            var gamesinSF = (48 - weekends) * (3.0/4);
            var gamesonHD = holidays * (2.0 / 3);
            var gamesatAll = weekends + gamesinSF + gamesonHD;
            if (year=="leap")
            {
                gamesatAll += gamesatAll * 0.15;
            }
            Console.WriteLine(Math.Truncate(gamesatAll));

        }
    }
}
