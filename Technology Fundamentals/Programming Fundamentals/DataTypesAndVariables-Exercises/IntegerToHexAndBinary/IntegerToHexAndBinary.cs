using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(number, 16);
            hexadecimal = hexadecimal.ToUpper();
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"{hexadecimal}\n{binary}");
        }
    }
}
