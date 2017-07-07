using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalType
{
    class AnimalType
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                default:
                    Console.WriteLine("unknown");
                    break;
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;

            }
        }
    }
}
