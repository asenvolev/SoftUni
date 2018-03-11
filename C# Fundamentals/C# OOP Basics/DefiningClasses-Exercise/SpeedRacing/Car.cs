using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelPer1Km;
        private double kmDriven;

        public Car(string model, double fuelAmount, double fuelPer1Km)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.fuelPer1Km = fuelPer1Km;
            this.kmDriven = 0;
        }
        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }
        public void Drive(double kmDriven)
        {
            if (this.fuelAmount < kmDriven * this.fuelPer1Km)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= kmDriven * this.fuelPer1Km;
                this.kmDriven += kmDriven;
            }
        }
        public override string ToString()
        {
            return $"{this.model} {this.fuelAmount:f2} {this.kmDriven}";
        }

    }
}
