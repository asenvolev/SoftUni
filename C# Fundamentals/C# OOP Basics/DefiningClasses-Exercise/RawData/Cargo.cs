using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Cargo
    {
        private int weight;
        private string type;
        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
        public int Weight => this.weight;
        public string Type => this.type;
    }
}
