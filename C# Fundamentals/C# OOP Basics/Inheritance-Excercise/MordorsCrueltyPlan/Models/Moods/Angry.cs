using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models.Moods
{
    public class Angry:Mood
    {
        private const string MoodName = "Angry";
        public Angry():base(MoodName)
        {

        }
    }
}
