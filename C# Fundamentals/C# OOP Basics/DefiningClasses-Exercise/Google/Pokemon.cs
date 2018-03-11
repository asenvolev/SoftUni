using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Pokemon
    {
        private string name;
        private string type;
        public Pokemon(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        public string Name => this.name;
        public string Type => this.type;
    }
}
