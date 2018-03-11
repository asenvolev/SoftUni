using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();
            for (int i = 0; i < numOfEngines; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                int power = int.Parse(input[1]);
                if (input.Length == 3)
                {
                    int displacement;
                    if (int.TryParse(input[2], out displacement))
                    {
                        var engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        string efficiency = input[2];
                        var engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }
                }
                else if (input.Length<3)
                {
                    var engine = new Engine(model, power);
                    engines.Add(engine);
                }
                else
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    var engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
            }
            var numOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < numOfCars; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                string model = input[0];
                var engine = engines.Where(x => x.Model == input[1]).First();
                if (engine!=null)
                {
                    if (input.Length == 3)
                    {
                        int weight;
                        if (int.TryParse(input[2], out weight))
                        {
                            var car = new Car(model, engine, weight);
                            cars.Add(car);
                        }
                        else
                        {
                            string color = input[2];
                            var car = new Car(model, engine, color);
                            cars.Add(car);
                        }
                    }
                    else if (input.Length < 3)
                    {
                        var car = new Car(model, engine);
                        cars.Add(car);
                    }
                    else
                    {
                        int weight = int.Parse(input[2]);
                        string color = input[3];
                        var car = new Car(model, engine, weight, color);
                        cars.Add(car);
                    }
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
