using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MordorsCrueltyPlan.Models.Foods
{
    public class Lembas:Food
    {
        private const int HappinessPoints = 3;
        public Lembas():base(HappinessPoints)
        {

        }
    }
}
