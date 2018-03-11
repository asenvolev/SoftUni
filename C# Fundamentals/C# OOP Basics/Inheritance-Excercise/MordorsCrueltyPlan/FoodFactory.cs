using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MordorsCrueltyPlan.Models;
using MordorsCrueltyPlan.Models.Foods;


namespace MordorsCrueltyPlan
{
    public class FoodFactory
    {
        public Food GetFood(string food)
        {
            switch (food.ToLower())
            {
                default:
                    return new Junk();
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    return new Apple();
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
            }
        }
    }
}
