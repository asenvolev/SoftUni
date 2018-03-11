using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double horizontal;
        private double vertical;
        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.horizontal = horizontal;
            this.vertical = vertical;
        }
        public string Id => this.id;
        public double Width => this.width;
        public double Height => this.height;
        public double Horizontal => this.horizontal;
        public double Vertical => this.vertical;
        public bool IntersectsWith(Rectangle rec)
        {
            return !(this.horizontal > rec.Horizontal + rec.Width || this.horizontal + this.width < rec.Horizontal || this.vertical > rec.Vertical + rec.Height || this.vertical + this.height < rec.Vertical);
        }

    }
}
