using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var column = int.Parse(Console.ReadLine());
            var places = row * column;
            var price = 0.0;
            var total = 0.0;
            switch (type)
            {
                default:
                    Console.WriteLine("error");
                    break;
                case "premiere":
                    price = 12;
                    break;
                case "normal":
                    price = 7.50;
                    break;
                case "discount":
                    price = 5;
                    break;
            }
            total = price * places;
            Console.WriteLine("{0:f2}",total);
        }
    }
}
