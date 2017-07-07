using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine().ToLower();
            var pricestudents = 0.0;
            var priceadults = 0.0;
            var traindiscount = 1.0;
            switch (transport)
            {
                default:
                    Console.WriteLine("incorrect type of transport");
                    break;
                case "train":
                    priceadults = 24.99;
                    pricestudents = 14.99;
                    if (students+adults>=50)
                    {
                        traindiscount = 0.5;
                    }
                    break;
                case "bus":
                    priceadults = 32.50;
                    pricestudents = 28.50;
                        break;
                case "boat":
                    priceadults = 42.99;
                    pricestudents = 39.99;
                    break;
                case "airplane":
                    priceadults = 70.00;
                    pricestudents = 50.00;
                    break;
            }
            var sum = priceadults * traindiscount*adults*2 + pricestudents * traindiscount*students*2 + nights * 82.99;
            var comission = sum * 0.1;
            sum += comission;
            Console.WriteLine("{0:f2}",sum);
        }
    }
}
