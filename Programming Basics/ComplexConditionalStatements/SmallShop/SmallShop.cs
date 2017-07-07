using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var artikyl = Console.ReadLine();
            var grad = Console.ReadLine();
            var kol = double.Parse(Console.ReadLine());
            var coffee = 0.50;
            var water = 0.80;
            var beer = 1.20;
            var sweets = 1.45;
            var peanuts = 1.60;
            if (artikyl == "coffee")
            {
                if (grad == "Sofia")
                {
                    Console.WriteLine(coffee*kol);
                }
                else if (grad=="Plovdiv")
                {
                    coffee -= 0.10;
                    Console.WriteLine(coffee * kol);
                }
                else
                {
                    coffee -= 0.05;
                    Console.WriteLine(coffee * kol);
                }
            }
            else if (artikyl == "water")
            {
                if (grad == "Sofia")
                {
                    Console.WriteLine(water * kol);
                }
                else if (grad == "Plovdiv")
                {
                    water -= 0.10;
                    Console.WriteLine(water * kol);
                }
                else
                {
                    water -= 0.10;
                    Console.WriteLine(water * kol);
                }
            }
            else if (artikyl == "beer")
            {
                if (grad == "Sofia")
                {
                    Console.WriteLine(beer * kol);
                }
                else if (grad == "Plovdiv")
                {
                    beer -= 0.05;
                    Console.WriteLine(beer * kol);
                }
                else
                {
                    beer -= 0.1;
                    Console.WriteLine(beer * kol);
                }
            }
            if (artikyl == "sweets")
            {
                if (grad == "Sofia")
                {
                    Console.WriteLine(sweets * kol);
                }
                else if (grad == "Plovdiv")
                {
                    sweets -= 0.15;
                    Console.WriteLine(sweets * kol);
                }
                else
                {
                    sweets -= 0.10;
                    Console.WriteLine(sweets * kol);
                }
            }
            if (artikyl == "peanuts")
            {
                if (grad == "Sofia")
                {
                    Console.WriteLine(peanuts * kol);
                }
                else if (grad == "Plovdiv")
                {
                    peanuts -= 0.10;
                    Console.WriteLine(peanuts * kol);
                }
                else
                {
                    peanuts -= 0.05;
                    Console.WriteLine(peanuts * kol);
                }
            }
        }
    }
}
