using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            while (input!="End")
            {
                var animalTokens = input.Split(new[] { ' ', '\n', '\t' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                Animal animal = GetAnimal(animalTokens);
                
                input = Console.ReadLine();
                var foodTokens = input.Split(new[] { ' ', '\n', '\t' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();
                Food food = GetFood(foodTokens);
                Console.WriteLine(animal.makeSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine(animal.ToString());

                input = Console.ReadLine();
            }
        }

        private static Food GetFood(string[] foodTokens)
        {
            string type = foodTokens[0];
            int quantity = int.Parse(foodTokens[1]);
            if (type == "Meat")
            {
                Food meat = new Meat(quantity);
                return meat;
            }
            else
            {
                Food vegetable = new Vegetable(quantity);
                return vegetable;
            }
        }

        private static Animal GetAnimal(string[] animalTokens)
        {
            string type = animalTokens[0];
            string name = animalTokens[1];
            double weight = double.Parse(animalTokens[2]);
            string livingRegion = animalTokens[3];
            switch (type)
            {
                default:
                    return null;
                case "Mouse":
                    Animal mouse = new Mouse(name, type, weight, livingRegion);
                    return mouse;
                case "Zebra":
                    Animal zebra = new Zebra(name, type, weight, livingRegion);
                    return zebra;
                case "Tiger":
                    Animal tiger = new Tiger(name, type, weight, livingRegion);
                    return tiger;
                case "Cat":
                    Animal cat = new Cat(name, type, weight, livingRegion, animalTokens[4]);
                    return cat;
            }
        }
    }
}
