using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Entities
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corps, IList<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }
        public IList<Mission> Missions { get; private set; }
        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Missions:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");
            return sb.ToString().Trim();
        }
    }
}
