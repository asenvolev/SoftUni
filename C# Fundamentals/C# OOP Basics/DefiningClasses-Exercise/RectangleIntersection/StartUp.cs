using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleIntersection
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var numOfRectangles = int.Parse(firstLine[0]);
            var numOfIntersections = int.Parse(firstLine[1]);
            var rectangles = new List<Rectangle>();
            for (int i = 0; i < numOfRectangles; i++)
            {
                var input = Console.ReadLine().Split();
                var rectangle = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4]));
                rectangles.Add(rectangle);
            }
            for (int i = 0; i < numOfIntersections; i++)
            {
                var rectangleIds = Console.ReadLine().Split();
                string firstRecId = rectangleIds[0];
                string secRecId = rectangleIds[1];
                var firstRec = rectangles.Where(x => x.Id == firstRecId).First();
                var secRec = rectangles.Where(x => x.Id == secRecId).First();
                if (firstRec != null && secRec!= null)
                {
                    if (firstRec.IntersectsWith(secRec))
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                
            }
        }
    }
}
