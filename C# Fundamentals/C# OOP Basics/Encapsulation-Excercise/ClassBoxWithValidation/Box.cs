using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBoxWithValidation
{
    public class Box
    {
        private double lenght;
        private double width;
        private double height;
        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public  double Lenght
        {
            get { return this.lenght; }
            private set
            {
                if (value <=0)
                {
                    throw new ArgumentException($"{nameof(Lenght)} cannot be zero or negative.");
                }
                this.lenght = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                this.height = value;
            }
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
