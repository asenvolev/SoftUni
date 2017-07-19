using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Greater number: " + num1);
            } 
            else if(num1<num2)
            {
                Console.WriteLine("Greater number: " + num2);
            }
            else
            {
                Console.WriteLine("Greater number: " + num1);
            }
        }
    }
}
