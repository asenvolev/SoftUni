using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MordorsCrueltyPlan.Models;
using MordorsCrueltyPlan.Models.Moods;

namespace MordorsCrueltyPlan
{
    public class MoodFactory
    {
        public Mood GetMood(int happinesPoints)
        {
            if (happinesPoints < -5)
            {
                return new Angry();
            }
            else if (happinesPoints < 1)
            {
                return new Sad();
            }
            else if (happinesPoints < 16)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}
