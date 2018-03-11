using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public interface IBuyer
    {
        string Name { get; }
        int Age { get; }
        int Food { get; }
        void BuyFood();
    }
}
