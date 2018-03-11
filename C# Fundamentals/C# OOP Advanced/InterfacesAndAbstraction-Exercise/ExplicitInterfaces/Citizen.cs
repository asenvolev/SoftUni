using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    public class Citizen : IPerson, IResident
    {
        public int Age { get; private set; }

        public string Country { get; private set; }

        public string Name { get; private set; }
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }
        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return this.Name;
        }
    }
}
