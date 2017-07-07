using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitcoins = double.Parse(Console.ReadLine());
            var china = double.Parse(Console.ReadLine());
            var comission = double.Parse(Console.ReadLine());
            var dolars = china * 0.15;
            var leva = 1168 * bitcoins;
            var euro = leva/1.95 + dolars*1.76/1.95;
            Console.WriteLine(euro - (euro*comission/100));


            

        }
    }
}
