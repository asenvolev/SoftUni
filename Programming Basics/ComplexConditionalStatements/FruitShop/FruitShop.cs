using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            var artikyl = Console.ReadLine();
            var den = Console.ReadLine();
            var kol = double.Parse(Console.ReadLine());
            var banana = 2.50;
            var apple = 1.20;
            var orange = 0.85;
            var grapefruit = 1.45;
            var kiwi = 2.70;
            var pineapple = 5.50;
            var grapes = 3.85;
            if (den == "Saturday" || den == "Sunday")
            {
                banana += 0.20;
                apple += 0.05;
                orange += 0.05;
                grapefruit += 0.15;
                kiwi += 0.30;
                pineapple += 0.10;
                grapes += 0.35;
            }
            else if ( den != "Monday" && den != "Tuesday" && den != "Wednesday" && den != "Thursday" && den != "Friday")
            {
                Console.WriteLine("error");
            }
            switch (artikyl)
            {
                case "banana":
                    Console.WriteLine(banana*kol);
                    break;
                case "apple":
                    Console.WriteLine(apple * kol);
                    break;
                case "orange":
                    Console.WriteLine(orange * kol);
                    break;
                case "grapefruit":
                    Console.WriteLine(grapefruit * kol);
                    break;
                case "kiwi":
                    Console.WriteLine(kiwi * kol);
                    break;
                case "pineapple":
                    Console.WriteLine(pineapple * kol);
                    break;
                case "grapes":
                    Console.WriteLine(grapes * kol);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
