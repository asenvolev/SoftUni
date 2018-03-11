using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Person
    {
        private string name;
        private Car car;
        private Company company;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;
        public Person()
        {
            this.parents = new List<Parent>();
            this.children = new List<Child>();
            this.pokemons = new List<Pokemon>();
        }
        public Person(string name, Car car)
        {
            this.name = name;
            this.car = car;
        }
        public Person(string name, Company company)
        {
            this.name = name;
            this.company = company;
        }
        public Person(string name, List<Parent> parents)
        {
            this.name = name;
            this.parents = parents;
        }
        public Person(string name, List<Child> children)
        {
            this.name = name;
            this.children = children;
        }
        public Person(string name, List<Pokemon> pokemons)
        {
            this.name = name;
            this.pokemons = pokemons;
        }
        public string Name => this.name;
        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }
        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }
        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }
        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
    }
}
