using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public abstract class Mammal:Animal
    {
        protected string LivingRegion { get; set; }
        public Mammal(string name, string type, double weight, string livingRegion)
            :base(name,type,weight)
        {
            this.LivingRegion = livingRegion;
        }
        public override string ToString()
        {
            return $"{this.Type}[{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
