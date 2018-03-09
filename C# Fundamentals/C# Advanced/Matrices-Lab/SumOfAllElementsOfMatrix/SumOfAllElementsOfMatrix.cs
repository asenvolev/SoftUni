using System;
using System.Linq;

namespace SumOfAllElementsOfMatrix
{
    public class SumOfAllElementsOfMatrix
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[input[0]][];
            int sum = 0;
            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                var inputrow = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[rowIndex] = inputrow;
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row].Sum();
            }
            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            Console.WriteLine(sum);
        }
    }
}
