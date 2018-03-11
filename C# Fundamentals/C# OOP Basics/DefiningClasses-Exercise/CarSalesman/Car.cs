using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;
        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = "n/a";
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.color = color;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }
        
        public override string ToString()
        {
            string Displacement = this.engine.Displacement.ToString();
            string weight = this.weight.ToString();
            if (this.engine.Displacement == -1)
            {
                Displacement = "n/a";
            }
            if (this.weight == -1)
            {
                weight = "n/a";
            }
            return $"{this.model}:\n  {this.engine.Model}:\n    Power: {this.engine.Power}\n    Displacement: {Displacement}\n    Efficiency: {this.engine.Efficiency}\n  Weight: {weight}\n  Color: {this.color}";
        }
    }
}
