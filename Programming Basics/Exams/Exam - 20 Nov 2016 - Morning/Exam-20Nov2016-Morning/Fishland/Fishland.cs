using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Fishland
    {
        static void Main(string[] args)
        {
            var skumriq = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var kgpalamud = double.Parse(Console.ReadLine());
            var kgsafrid = double.Parse(Console.ReadLine());
            var kgmidi = double.Parse(Console.ReadLine());
            var palamud = skumriq * 1.6;
            var safrid = 1.8 * caca;
            var midi = 7.50;
            var obshto = kgpalamud * palamud + kgsafrid * safrid + kgmidi * midi;
            Console.WriteLine("{0:f2}",obshto);
        }
    }
}
