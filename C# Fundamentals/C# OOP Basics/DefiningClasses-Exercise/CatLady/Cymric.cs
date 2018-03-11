using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class Cymric
    {
        private string name;
        private double furLength;
        public Cymric(string name, double furLength)
        {
            this.name = name;
            this.furLength = furLength;
        }
        public string Name => this.name;
        public override string ToString()
        {
            return $"Cymric {this.name} {this.furLength:f2}";
        }
    }
}
