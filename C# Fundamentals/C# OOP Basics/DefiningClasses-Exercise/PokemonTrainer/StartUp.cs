using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var trainers = new HashSet<Trainer>();
            while (input!="Tournament")
            {
                var tokens = input.Split();
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string element = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);
                if (trainers.Any(x=>x.Name == trainerName))
                {
                    var pokemon = new Pokemon(pokemonName, element, pokemonHealth);
                    trainers.Where(x => x.Name == trainerName).FirstOrDefault().Pokemons.Add(pokemon);
                }
                else
                {
                    var trainer = new Trainer(trainerName, new List<Pokemon>() { new Pokemon(pokemonName, element, pokemonHealth) });
                    trainers.Add(trainer);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input!="End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(x=>x.Element==input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons.ToList())
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health<=0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
