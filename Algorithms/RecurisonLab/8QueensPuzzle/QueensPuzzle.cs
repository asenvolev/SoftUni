using System;
using System.Collections.Generic;

namespace _8QueensPuzzle
{
    public class QueensPuzzle
    {
        static int[,] matrix;
        const int Size = 8;
        static HashSet<int> atackedRows;
        static HashSet<int> atackedCols;
        static HashSet<int> atackedLeftDiagonals;
        static HashSet<int> atackedRightDiagonals;

        public static void Main()
        {
            atackedRows = new HashSet<int>();
            atackedCols = new HashSet<int>();
            atackedLeftDiagonals = new HashSet<int>();
            atackedRightDiagonals = new HashSet<int>();
            matrix = new int[Size,Size];
            PutQueens(0);
        }

        private static void PutQueens(int row = 0)
        {
            if (row == matrix.GetLength(0))
            {
                PrintSolution();
                return;
            }
            else
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (CanPlaceQueen(row,col))
                    {
                        MarkAllAtackedPositons(row,col);
                        PutQueens(row + 1);
                        UnmarkAllAtackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkAllAtackedPositions(int row, int col)
        {
            atackedCols.Remove(col);
            atackedRows.Remove(row);
            atackedLeftDiagonals.Remove(col - row);
            atackedRightDiagonals.Remove(row + col);
            matrix[row, col] = 0;
        }

        private static void MarkAllAtackedPositons(int row, int col)
        {
            atackedCols.Add(col);
            atackedRows.Add(row);
            atackedLeftDiagonals.Add(col - row);
            atackedRightDiagonals.Add(row + col);
            matrix[row, col] = 1;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            return !(atackedCols.Contains(col) || atackedRows.Contains(row) || atackedLeftDiagonals.Contains(col - row) ||
                atackedRightDiagonals.Contains(row + col));
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 0)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
