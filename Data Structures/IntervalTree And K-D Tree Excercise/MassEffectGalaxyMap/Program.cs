using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        int numOfStarClusters = int.Parse(Console.ReadLine());
        int numOfReports = int.Parse(Console.ReadLine());
        int galaxySize = int.Parse(Console.ReadLine());
        Rectangle space = new Rectangle(0, galaxySize, 0, galaxySize);

        List<Point2D> points = new List<Point2D>();

        for (int i = 0; i < numOfStarClusters; i++)
        {
            var starCluster = Console.ReadLine().Split(' ');
            string name = starCluster[0];
            int x = int.Parse(starCluster[1]);
            int y = int.Parse(starCluster[2]);

            Point2D currPoint = new Point2D(x, y);
            if (currPoint.IsInRectangle(space))
            {
                points.Add(currPoint);
            }
        }

        //tree.BuildFromList(points);

        KdTree tree = new KdTree();

        points.ForEach(tree.Insert);
        points.Clear();

        for (int i = 0; i < numOfReports; i++)
        {
            var tokens = Console.ReadLine().Split().Skip(1).Select(double.Parse).ToArray();
            Rectangle rect = new Rectangle(tokens[0], tokens[0] + tokens[2], tokens[1], tokens[1] + tokens[3]);

            tree.GetPoints(points.Add, rect, space);

            Console.WriteLine(points.Count);
            points.Clear();
        }
    }
}

