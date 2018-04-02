using System;
using System.Collections.Generic;
using System.Linq;

namespace FindPathsInLabyrinth
{
    public class Program
    {
        static char[][] matrix;
        static List<char> path;
        public static void Main()
        {
            var height = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());

            path = new List<char>();
            matrix = new char[height][];

            for (int row = 0; row < height; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }

            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBounds(row,col))
            {
                return;
            }

            path.Add(direction);

            if (IsExit(row,col))
            {
                PrintSolution();
            }
            else
            {
                if (!IsVisited(row,col) && IsFree(row,col))
                {
                    MarkVisited(row, col);
                    FindPaths(row - 1, col, 'U');
                    FindPaths(row + 1, col, 'D');
                    FindPaths(row, col + 1, 'R');
                    FindPaths(row, col - 1, 'L');
                    UnmarkVisited(row, col);
                }
            }
            path.RemoveAt(path.Count - 1);
        }

        private static bool IsFree(int row, int col)
        {
            return matrix[row][col] != '*';
        }

        private static void UnmarkVisited(int row, int col)
        {
            matrix[row][col] = '-';
        }

        private static void MarkVisited(int row, int col)
        {
            matrix[row][col] = 'v';
        }

        private static void PrintSolution()
        {
            Console.WriteLine(String.Join("",path.Skip(1)));
        }

        private static bool IsVisited(int row, int col)
        {
            return matrix[row][col] == 'v';
        }

        private static bool IsExit(int row, int col)
        {
            return matrix[row][col] == 'e';
        }

        private static bool IsInBounds(int row, int col)
        {
            return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[0].Length;
        }
    }
}
