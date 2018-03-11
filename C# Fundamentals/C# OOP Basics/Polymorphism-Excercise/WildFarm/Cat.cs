using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Cat : Mammal
    {
        private string Breed { get; set; }
        public Cat(string name, string type, double weight, string livingRegion, string breed)
            :base(name,type,weight,livingRegion)
        {
            this.Breed = breed;
        }
        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
        public override string makeSound()
        {
            return "Meowwww";
        }
    }
}
