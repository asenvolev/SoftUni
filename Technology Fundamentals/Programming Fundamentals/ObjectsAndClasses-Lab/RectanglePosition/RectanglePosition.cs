using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePosition
{
    class RectanglePosition
    {
        class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            public int Bottom => Top - Height;
            public int Right => Left + Width;
            public static bool firstInsideSecond(Rectangle firstRectangle, Rectangle secondRectangle)
            {
                bool leftIsInside = firstRectangle.Left >= secondRectangle.Left;
                bool topIsInside = firstRectangle.Top <= secondRectangle.Top;
                bool rightIsInside = firstRectangle.Right <= secondRectangle.Right;
                bool bottomIsInside = firstRectangle.Bottom >= secondRectangle.Bottom;
                return (leftIsInside && topIsInside && rightIsInside && bottomIsInside);
            }
        }
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var firstRectangle = new Rectangle
            {
                Left = int.Parse(input[0]),
                Top = int.Parse(input[1]),
                Width = int.Parse(input[2]),
                Height = int.Parse(input[3])
            };
            var secondInput = Console.ReadLine().Split();
            var secondRectangle = new Rectangle
            {
                Left = int.Parse(secondInput[0]),
                Top = int.Parse(secondInput[1]),
                Width = int.Parse(secondInput[2]),
                Height = int.Parse(secondInput[3])
            };
            bool insideOrNot = Rectangle.firstInsideSecond(firstRectangle, secondRectangle);
            if (insideOrNot)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        
    }
}
