using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirhtable, IBuyer
    {
        private int food;
        public int Food
        {
            get
            {
                return this.food;
            }

            private set
            {
                this.food = value;
            }
        }
        public string Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }

        public string BirthDate { get; private set; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
            this.Food = 0;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
