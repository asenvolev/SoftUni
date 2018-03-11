using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Zebra : Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion)
            :base(name,type,weight,livingRegion)
        {

        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{GetType().Name}s are not eating that type of food!");
            }
            base.Eat(food);
        }
        public override string makeSound()
        {
            return "Zs";
        }
    }
}
