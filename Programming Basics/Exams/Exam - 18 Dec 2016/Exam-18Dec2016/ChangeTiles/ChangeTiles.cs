using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var shirochina = double.Parse(Console.ReadLine());
            var duljina = double.Parse(Console.ReadLine());
            var triangleA = double.Parse(Console.ReadLine());
            var Htriangle = double.Parse(Console.ReadLine());
            var pricepertile = double.Parse(Console.ReadLine());
            var maistor = double.Parse(Console.ReadLine());
            var Spod = shirochina * duljina;
            var Stile = triangleA * Htriangle / 2;
            var tilesneeded = Math.Ceiling(Spod / Stile) + 5;
            var atall = tilesneeded * pricepertile + maistor;
            if (money >=atall)
            {
                Console.WriteLine("{0:f2} lv left.",money-atall);
            }
            else
            {
                Console.WriteLine("You'll need {0:f2} lv more.",atall-money);
            }
        }
    }
}
