using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models
{
    public abstract class Food
    {
        protected Food(int happinessPoints)
        {
            this.HappinessPoints = happinessPoints;
        }
        public int HappinessPoints { get; set; }
        public int GetHappinessPoints()
        {
            return this.HappinessPoints;
        }
    }
}
