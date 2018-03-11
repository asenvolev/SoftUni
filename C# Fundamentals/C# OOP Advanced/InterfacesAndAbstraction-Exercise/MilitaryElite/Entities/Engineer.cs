using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Entities
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, string corps, IList<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }
        public IList<Repair> Repairs { get; }
        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Repairs:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Repairs)}");
            return sb.ToString().Trim();
        }
    }
}
