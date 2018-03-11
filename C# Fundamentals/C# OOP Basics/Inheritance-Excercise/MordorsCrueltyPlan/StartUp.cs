using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MordorsCrueltyPlan.Models;
namespace MordorsCrueltyPlan
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();
            var gandalf = new Gandalf();
            var foods = Console.ReadLine().Split(new[] { ' ', '\t', '\n' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var foodString in foods)
            {
                Food food = foodFactory.GetFood(foodString);
                gandalf.Eat(food); 
            }
            int happinessPoints = gandalf.GetHappinesPoints();
            Mood mood = moodFactory.GetMood(happinessPoints);
            Console.WriteLine(happinessPoints);
            Console.WriteLine(mood);
        }
    }
}
