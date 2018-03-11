using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models
{
    public abstract class Mood
    {
        public string MoodName { get; set; }
        public Mood(string moodName)
        {
            this.MoodName = moodName;
        }
        public string GetMood()
        {
            return this.MoodName;
        }
        public override string ToString()
        {
            return $"{this.GetMood()}";
        }
    }
}
