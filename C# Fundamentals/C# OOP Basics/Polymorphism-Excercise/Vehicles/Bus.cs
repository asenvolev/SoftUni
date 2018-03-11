using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Bus : Vehicle
    {
        private const double AcConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption + AcConsumption, tankCapacity)
        {

        }
        public override string DriveEmpty(double distance)
        {
            if (distance * (this.FuelConsumption- AcConsumption) <= this.FuelQuantity)
            {
                this.FuelQuantity -= (distance * (this.FuelConsumption - AcConsumption));
                return $"Bus travelled {distance} km";
            }
            return $"Bus needs refueling";
        }
        public override void Refuel(double liters)
        {
            if (liters<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters+this.FuelQuantity>this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            base.Refuel(liters);
        }
    }
}
