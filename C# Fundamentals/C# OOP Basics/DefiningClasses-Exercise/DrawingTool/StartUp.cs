using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingTool
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            switch (input)
            {
                default:
                    break;
                case "Square":
                    var side = int.Parse(Console.ReadLine());
                    var square = new corDraw(side);
                    Console.WriteLine(square.Draw());
                    break;
                case "Rectangle":
                    var width = int.Parse(Console.ReadLine());
                    var height = int.Parse(Console.ReadLine());
                    var rectangle = new corDraw(height,width);
                    Console.WriteLine(rectangle.Draw());
                    break;
            }
        }
    }
}
