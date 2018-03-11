using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Child
    {
        private string name;
        private string birthday;
        public Child(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public string Name => this.name;
        public string Birthday => this.birthday;
    }
}
