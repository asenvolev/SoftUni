using System;
using System.Linq;

namespace MaximalSum
{
    public class MaximalSum
    {
        public static void Main()
        {
            var size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new int[size[0]][];
            int maxValue = int.MinValue;
            int sum = 0;
            var bestMatrix = new int[3][];
            for (int col = 0; col < size[0]; col++)
            {
                matrix[col] = new int[size[1]];
                matrix[col] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < size[1] - 2; col++)
                {
                    for (int r = 0; r < 3; r++)
                    {
                        sum += matrix[row + r].Skip(col).Take(3).Sum();
                    }
                    if (sum > maxValue)
                    {
                        maxValue = sum;

                        for (int r = 0; r < bestMatrix.Length; r++)
                        {
                            bestMatrix[r] = new int[3];
                            for (int c = 0; c < bestMatrix.Length; c++)
                            {
                                bestMatrix[r][c] = matrix[row + r][col + c];
                            }

                        }
                    }
                    sum = 0;
                }
            }
            Console.WriteLine($"Sum = {maxValue}");
            foreach (var row in bestMatrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
