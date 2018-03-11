using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class Siamese
    {
        private string name;
        private int earSize;
        public Siamese(string name, int earSize)
        {
            this.name = name;
            this.earSize = earSize;
        }
        public string Name => this.name;

        public override string ToString()
        {
            return $"Siamese {this.name} {this.earSize}";
        }
    }
}
