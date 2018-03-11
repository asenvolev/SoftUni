using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models.Moods
{
    public class Sad:Mood
    {
        private const string MoodName = "Sad";
        public Sad():base(MoodName)
        {

        }
    }
}
