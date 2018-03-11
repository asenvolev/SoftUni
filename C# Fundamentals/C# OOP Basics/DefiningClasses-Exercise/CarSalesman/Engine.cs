using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;
        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            this.displacement = -1;
            this.efficiency = "n/a";
        }
        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.displacement = displacement;
        }
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
        public string Model => this.model;
        public int Power => this.power;
        public string Efficiency => this.efficiency;
        public int Displacement => this.displacement;

    }
}
