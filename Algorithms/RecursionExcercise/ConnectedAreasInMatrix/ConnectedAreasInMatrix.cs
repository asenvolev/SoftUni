using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedAreasInMatrix
{
    public class ConnectedAreasInMatrix
    {
        static char[,] matrix;

        static int counter = 0;

        public static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            matrix = new char[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            FindAreas();
        }

        public static void FindAreas()
        {
            int areasFound = 0;
            List<Area> allAreas = new List<Area>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == '-')
                    {
                        TransverseArea(i, j);
                        areasFound++;
                        allAreas.Add(new Area(counter, i, j));
                        counter = 0;
                    }
                }
            }

            allAreas = allAreas.OrderByDescending(x => x.Size).ThenBy(x => x.Row).
                ThenBy(x => x.Column).
                ToList();

            Console.WriteLine($"Total areas found: {areasFound}");

            int areaPosition = 1;
            foreach (var area in allAreas)
            {
                PrintResultForCurrentArea(areaPosition, area.Row, area.Column, area.Size);
                areaPosition++;
            }
        }

        public static void TransverseArea(int x, int y)
        {
            if (x < 0 || y < 0 || x == matrix.GetLength(0) || y == matrix.GetLength(1))
            {
                return;
            }

            if (matrix[x, y] != '-')
            {
                return;
            }

            MarkCell(x, y);
            counter++;
            TransverseArea(x, y - 1); //left
            TransverseArea(x + 1, y); //down
            TransverseArea(x, y + 1); //right
            TransverseArea(x - 1, y); //up

        }

        private static void MarkCell(int x, int y)
        {
            matrix[x, y] = 'M';
        }

        public static void PrintResultForCurrentArea(int areaNumber, int x, int y, int cellsCount)
        {
            Console.WriteLine($"Area #{areaNumber} at ({x}, {y}), size: {cellsCount}");
        }
    }

    internal class Area
    {
        public int Size;
        public int Row;
        public int Column;

        public Area(int Size, int Row, int Column)
        {
            this.Size = Size;
            this.Row = Row;
            this.Column = Column;
        }
    }
}
