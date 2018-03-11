using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Pet : IBirhtable
    {
        public string BirthDate { get; private set; }

        public string Name { get; private set; }
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }
    }
}
