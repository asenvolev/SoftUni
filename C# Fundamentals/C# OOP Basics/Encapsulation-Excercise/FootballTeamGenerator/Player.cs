using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    class Player
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");

                _name = value;
            }
        }

        public List<Skill> Stats { get; }

        public Player(string name, List<Skill> stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
    }
}

