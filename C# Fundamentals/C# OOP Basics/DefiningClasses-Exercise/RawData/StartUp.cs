using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var listOfCars = new List<Car>();
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                double firstTire = double.Parse(input[5]);
                int firstTireAge = int.Parse(input[6]);
                double secondTire = double.Parse(input[7]);
                int secondTireAge = int.Parse(input[8]);
                double thirdTire = double.Parse(input[9]);
                int thirdTireAge = int.Parse(input[10]);
                double fourthTire = double.Parse(input[11]);
                int fourthTireAge = int.Parse(input[12]);
                var car = new Car(model, new Engine(speed, power), new Cargo(weight, type),
                    new List<Tire> { new Tire(firstTire, firstTireAge), new Tire(secondTire, secondTireAge),
                        new Tire(thirdTire, thirdTireAge), new Tire(fourthTire, fourthTireAge) });
                listOfCars.Add(car);
            }
            if (Console.ReadLine() == "fragile")
            {
                listOfCars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(c => c.Pressure < 1))
                    .Select(m => m.Model).ToList().ForEach(x => Console.WriteLine(x));
            }
            else
            {
                listOfCars.Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(m => m.Model).ToList().ForEach(x => Console.WriteLine(x));
            }
        }
    }
}
