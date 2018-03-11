using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models.Moods
{
    public class Happy:Mood
    {
        private const string MoodName = "Happy";
        public Happy():base(MoodName)
        {

        }
    }
}
