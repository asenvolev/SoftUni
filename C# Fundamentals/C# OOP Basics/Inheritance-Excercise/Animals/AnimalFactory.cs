using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class AnimalFactory
    {
        public Animal GetAnimal(string type, string[] info)
        {
            switch (type.ToLower())
            {
                default:
                    return null;
                case "cat":
                    return new Cat(info[0], int.Parse(info[1]), info[2]);
                case "dog":
                    return new Dog(info[0], int.Parse(info[1]), info[2]);
                case "frog":
                    return new Frog(info[0], int.Parse(info[1]), info[2]);
                case "kitten":
                    return new Kitten(info[0], int.Parse(info[1]));
                case "tomcat":
                    return new Tomcat(info[0], int.Parse(info[1]));
            }
        }
    }
}
