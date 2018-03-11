﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryElite.Entities
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary, IList<ISoldier> privates)
            : base (id, firstName,lastName, salary)
        {
            this.Privates = privates;
        }
        public IList<ISoldier> Privates { get; }
        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Privates:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Privates)}");
            return sb.ToString().Trim();
        }
    }
}
