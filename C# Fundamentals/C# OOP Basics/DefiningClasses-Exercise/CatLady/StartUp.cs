using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatLady
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var siameses = new List<Siamese>();
            var streets = new List<StreetExtraordinaire>();
            var cymrics = new List<Cymric>();
            var input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(' ');
                string type = tokens[0];
                string name = tokens[1];
                switch (type)
                {
                    default:
                        break;
                    case "StreetExtraordinaire":
                        int decibels = int.Parse(tokens[2]);
                        var streetExtraordinaire = new StreetExtraordinaire(name, decibels);
                        streets.Add(streetExtraordinaire);
                        break;
                    case "Cymric":
                        double furLength = double.Parse(tokens[2]);
                        var cymric = new Cymric(name, furLength);
                        cymrics.Add(cymric);
                        break;
                    case "Siamese":
                        int earSize = int.Parse(tokens[2]);
                        var siamese = new Siamese(name, earSize);
                        siameses.Add(siamese);
                        break;
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            if (streets.Any(x=>x.Name == input))
            {
                Console.WriteLine(streets.FirstOrDefault(x => x.Name == input));
            }
            else if (cymrics.Any(x => x.Name == input))
            {
                Console.WriteLine(cymrics.FirstOrDefault(x => x.Name == input));
            }
            else if (siameses.Any(x => x.Name == input))
            {
                Console.WriteLine(siameses.FirstOrDefault(x => x.Name == input));
            }
        }
    }
}
