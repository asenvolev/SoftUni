using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    public class SquareWithMaximumSum
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[input[0]][];
            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                var inputrow = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[rowIndex] = inputrow;
            }
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    int currSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] + matrix[row + 1][col + 1];
                    if (maxSum<currSum)
                    {
                        maxSum = currSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol+1]}\n{matrix[maxRow+1][maxCol]} {matrix[maxRow+1][maxCol+1]}\n{maxSum}");
        }
    }
}
