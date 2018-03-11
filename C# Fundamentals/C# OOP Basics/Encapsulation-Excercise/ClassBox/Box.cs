using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBox
{
    class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }
        public double SurfaceArea()
        {
            return this.lenght * this.width * 2 + this.lenght * this.height * 2 + this.width * this.height * 2;
        }
        public double LateralSurfaceArea()
        {
            return 2 * this.lenght * this.height + 2 * this.width * this.height;
        }
        public double Volume()
        {
            return this.lenght* this.width *this.height;
        }
        public override string ToString()
        {
            return $"Surface Area - {this.SurfaceArea():f2}\nLateral Surface Area - {this.LateralSurfaceArea():f2}\nVolume - {this.Volume():f2}";
        }
    }
}
