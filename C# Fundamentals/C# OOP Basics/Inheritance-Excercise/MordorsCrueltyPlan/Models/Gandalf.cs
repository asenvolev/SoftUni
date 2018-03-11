
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models
{
    public class Gandalf
    {
        private List<Food> foodEaten;
        public Gandalf()
        {
            this.foodEaten = new List<Food>();
        }
        public void Eat(Food food)
        {
            this.foodEaten.Add(food);
        }
        public int GetHappinesPoints()
        {
            return foodEaten.Sum(f => f.GetHappinessPoints());
        }
    }
}
