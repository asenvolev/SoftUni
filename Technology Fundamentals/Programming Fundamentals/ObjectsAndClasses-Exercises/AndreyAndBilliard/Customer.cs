using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> Product { get; set; }
        public decimal Bill { get; set; }
    }
}
