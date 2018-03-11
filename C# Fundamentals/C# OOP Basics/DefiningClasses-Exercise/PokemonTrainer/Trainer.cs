using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;
        public Trainer(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            this.badges = 0;
            this.pokemons = pokemons;
        }
        public string Name => this.name;
        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
        public int Badges
        {
            get { return this.badges; }
            set { this.badges = value; }
        }
    }
}
