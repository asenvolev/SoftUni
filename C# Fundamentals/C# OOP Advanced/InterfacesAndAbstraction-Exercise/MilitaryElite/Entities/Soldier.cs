using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Entities
{
    public abstract class Soldier : ISoldier
    {
        public Soldier(int id, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
