using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            var TruckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(TruckInfo[1]), double.Parse(TruckInfo[2]), double.Parse(TruckInfo[3]));
            var busInfo = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            int numOfComm = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfComm; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split();
                    if (input[1] == "Car")
                    {
                        driveOrRefuel(input[0], input[2], car);
                    }
                    else if (input[1] == "Bus")
                    {
                        driveOrRefuel(input[0], input[2], bus);
                    }
                    else
                    {
                        driveOrRefuel(input[0], input[2], truck);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void driveOrRefuel(string action, string litersOrDistance, Vehicle vehicle)
        {
            if (action == "Drive")
            {
                Console.WriteLine(vehicle.Drive(double.Parse(litersOrDistance)));
            }
            else if (action == "DriveEmpty")
            {
                Console.WriteLine(vehicle.DriveEmpty(double.Parse(litersOrDistance)));
            }
            else
            {
                vehicle.Refuel(double.Parse(litersOrDistance));
            }
        }
    }
}
