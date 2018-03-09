using System;
using System.Linq;

namespace SquaresInMatrix
{
    public class SquaresInMatrix
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new char[size[0]][];
            int counter = 0;
            for (int col = 0; col < size[0]; col++)
            {
                matrix[col] = new char[size[1]];
                matrix[col] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            }
            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < size[1]-1; col++)
                {
                    if (matrix[row][col] == matrix[row][col+1]
                        && matrix[row][col] == matrix[row+1][col]
                        && matrix[row+1][col] == matrix[row+1][col+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
