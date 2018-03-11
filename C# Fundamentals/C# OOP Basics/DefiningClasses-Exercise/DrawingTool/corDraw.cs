using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class corDraw
    {
        private int height;
        private int width;
        public corDraw(int height)
        {
            this.height = height;
            this.width = height;
        }
        public corDraw(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        public string Draw()
        {
            var sb = new StringBuilder();
            sb.AppendLine('|' + new string('-', this.width) +'|');
            for (int i = 0; i < this.height-2; i++)
            {
                sb.AppendLine('|' + new string(' ', this.width) +'|');
            }
            sb.AppendLine('|' + new string('-', this.width) + '|');
            return sb.ToString();
        }
    }
}
