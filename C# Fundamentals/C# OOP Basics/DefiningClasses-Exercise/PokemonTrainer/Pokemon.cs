﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    class Pokemon
    {
        private string name;
        private string element;
        private int health;
        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
        public string Element => this.element;
        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }
    }
}
