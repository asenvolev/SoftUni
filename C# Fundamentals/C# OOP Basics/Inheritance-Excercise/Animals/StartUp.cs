using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var animalFactory = new AnimalFactory();
            var input = Console.ReadLine();
            while (input!="Beast!")
            {
                var animalInfo = Console.ReadLine().Split(' ').ToArray();
                try
                {
                    var animal = animalFactory.GetAnimal(input, animalInfo);
                    Console.Write(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                input = Console.ReadLine();
            }
        }
    }
}
