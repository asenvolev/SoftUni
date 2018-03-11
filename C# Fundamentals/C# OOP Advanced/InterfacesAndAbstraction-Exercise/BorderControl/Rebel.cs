using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Rebel : IBuyer
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
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Group { get; private set; }
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
