using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Entities
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName,  double salary)
            : base (id, firstName, lastName)
        {
            this.Salary = salary;
        }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:f2}";
        }
    }
}
