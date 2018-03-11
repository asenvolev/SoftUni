using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Tire
    {
        private double pressure;
        private int tireAge;
        public Tire(double pressure, int tireAge)
        {
            this.pressure = pressure;
            this.tireAge = tireAge;
        }
        public double Pressure => this.pressure;
        public double TireAge => this.tireAge;
    }
}
