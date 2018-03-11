using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models.Foods
{
    public class Junk:Food
    {
        private const int HappinessPoints = -1;
        public Junk():base(HappinessPoints)
        {

        }
    }
}
