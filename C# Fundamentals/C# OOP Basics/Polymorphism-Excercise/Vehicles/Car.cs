using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AcConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption+AcConsumption, tankCapacity)
        {
            
        }
        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (liters + this.FuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            base.Refuel(liters);
        }
    }
}
