using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineAnInterfaceIPerson
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public int Age { get; private set; }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Citizen(string name, int age,string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }
    }
}
