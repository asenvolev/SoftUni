using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        protected string Type { get; set; }
        protected double Weight { get; set; }
        protected int FoodEaten { get; set; }
        public Animal(string name, string type, double weight)
        {
            this.Name = name;
            this.Type = type;
            this.Weight = weight;
        }
        public abstract string makeSound();
        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
        
    }
}
