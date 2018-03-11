using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class StreetExtraordinaire
    {
        private string name;
        private int decibels;
        public StreetExtraordinaire(string name, int decibels)
        {
            this.name = name;
            this.decibels = decibels;
        }
        public string Name => this.name;

        public override string ToString()
        {
            return $"StreetExtraordinaire {this.name} {this.decibels}";
        }
    }
}
