using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InfernoInfinity.Models.Gems;
using System.Threading.Tasks;

namespace InfernoInfinity.Factories
{
    public class GemFactory
    {
        public Gem Create(string tokens)
        {
            var elements = tokens.Split();
            Clarity clarity = (Clarity)(Enum.Parse(typeof(Clarity), elements[0]));
            string gemType = elements[1];
            switch (gemType)
            {
                default:
                    return null;
                case "Amethyst":
                    Gem amethyst = new Amethyst(clarity);
                    return amethyst;
                case "Emerald":
                    Gem emeral = new Emerald(clarity);
                    return emeral;
                case "Ruby":
                    Gem ruby = new Ruby(clarity);
                    return ruby;
            }
        }
    }
}
