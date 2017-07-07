using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine("");
            }
            else if (num < 100 || num > 200)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
