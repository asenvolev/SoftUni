using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    public class Ferrari : ICar
    {
        private const string ModelConst = "488-Spider";
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }
        public string Driver { get; private set; }
        
        public string Model
        {
            get
            {
                return ModelConst;
            }
        }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Zadu6avam sA!";
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Model).Append("/").Append(this.Brakes()).Append("/")
                .Append(this.GasPedal()).Append("/").Append(this.Driver);
            return sb.ToString();
        }
    }
}
