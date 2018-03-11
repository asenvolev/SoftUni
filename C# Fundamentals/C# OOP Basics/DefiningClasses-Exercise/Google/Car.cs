using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Car
    {
        private string model;
        private int speed;
        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }
        public string Model => this.model;
        public int Speed => this.speed;
    }
}
