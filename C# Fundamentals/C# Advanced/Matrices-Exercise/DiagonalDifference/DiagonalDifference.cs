using System;
using System.Linq;

namespace DiagonalDifference
{
    public class DiagonalDifference
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var matrix = new int[size][];
            int rightSum = 0;
            int leftSum = 0;
            for (int row = 0; row < size; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                leftSum += matrix[row][row];
                rightSum += matrix[row][size-1-row];
            }
            Console.WriteLine(Math.Abs(leftSum-rightSum));
        }
    }
}
