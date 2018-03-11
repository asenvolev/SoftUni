﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input !="End")
            {
                var tokens = input.Split(' ');
                var name = tokens[0];
                var country = tokens[1];
                var age = int.Parse(tokens[2]);

                Citizen citizen = new Citizen(name, country, age);
                IResident resident = citizen;
                IPerson person = citizen;

                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
                input = Console.ReadLine();
            }
        }
    }
}
