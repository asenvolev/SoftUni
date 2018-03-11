using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCustomClassAttribute
{
    public abstract class Gem
    {
        public Gem(Clarity clarity, int strength, int agility, int vitality)
        {
            this.Clarity = clarity;
            this.Agility = agility;
            this.Strength = strength;
            this.Vitality = vitality;
            this.SetClarity();
        }
        public Clarity Clarity { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Vitality { get; set; }
        public void SetClarity()
        {
            this.Strength += (int)this.Clarity;
            this.Agility += (int)this.Clarity;
            this.Vitality += (int)this.Clarity;
        }

    }
}
