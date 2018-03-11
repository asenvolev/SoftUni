using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            var numOfCars = int.Parse(Console.ReadLine());
            var list = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                var input = Console.ReadLine().Split();
                var car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                list.Add(car);
            }
            var drive = Console.ReadLine();
            while (drive!="End")
            {
                var tokens = drive.Split();
                var car = list.FirstOrDefault(x => x.Model == tokens[1]);
                if (car != null)
                {
                    car.Drive(double.Parse(tokens[2]));
                }
                drive = Console.ReadLine();
            }

            foreach (var car in list)
            {
                Console.WriteLine(car);
            }
        }
    }
}
