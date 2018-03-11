using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity.Models.Gems
{
    public class Emerald:Gem
    {
        private const int Strength = 1;
        private const int Agility = 4;
        private const int Vitality = 9;
        public Emerald(Clarity clarity) :base(clarity, Strength, Agility, Vitality)
        {

        }
    }
}
