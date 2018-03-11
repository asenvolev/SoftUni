using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.FuelQuantity = fuelQuantity;
            this.TankCapacity = tankCapacity;
        }
        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }

            set
            {
                this.fuelQuantity = value;
            }
        }

        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }

            set
            {
                this.fuelConsumption = value;
            }
        }

        public double TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }

            set
            {
                this.tankCapacity = value;
            }
        }

        public string Drive(double distance)
        {
            if (distance * this.FuelConsumption <= this.FuelQuantity)
            {
                this.FuelQuantity -= distance * this.FuelConsumption;
                return $"{GetType().Name} travelled {distance} km";
            }
            return $"{GetType().Name} needs refueling";
        }
        public virtual string DriveEmpty(double distance)
        {
            return "";
        }
        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += liters;
        }
        public override string ToString()
        {
            return $"{GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
