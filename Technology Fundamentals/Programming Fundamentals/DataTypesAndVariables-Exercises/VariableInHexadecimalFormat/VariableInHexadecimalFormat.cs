using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexadecimal = Console.ReadLine();
            int decim = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine(decim);
        }
    }
}
