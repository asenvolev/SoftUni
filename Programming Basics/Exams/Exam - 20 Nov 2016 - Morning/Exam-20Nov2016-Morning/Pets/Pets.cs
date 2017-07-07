using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var kgfood = int.Parse(Console.ReadLine());
            var kgfordogperday = double.Parse(Console.ReadLine());
            var kgforcatperday = double.Parse(Console.ReadLine());
            var gforturtleperday = double.Parse(Console.ReadLine());
            var atall = (kgfordogperday + kgforcatperday + gforturtleperday / 1000) * days;
            if (kgfood>=atall)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(kgfood-atall));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(atall - kgfood));

            }

        }
    }
}
