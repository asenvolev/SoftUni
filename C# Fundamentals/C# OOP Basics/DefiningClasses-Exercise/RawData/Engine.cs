using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    class Engine
    {
        private int speed;
        private int power;
        public Engine(int speed, int power)
        {
            this.speed = speed;
            this.power = power;
        }
        public int Speed => this.speed;
        public int Power => this.power;
    }
}
