using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models.Foods
{
    public class HoneyCake:Food
    {
        private const int HappinessPoints = 5;
        public HoneyCake():base(HappinessPoints)
        {

        }
    }
}
