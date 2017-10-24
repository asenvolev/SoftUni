using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            StringBuilder builder = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }

            Console.WriteLine(builder.ToString()); 
        }
    }
}
