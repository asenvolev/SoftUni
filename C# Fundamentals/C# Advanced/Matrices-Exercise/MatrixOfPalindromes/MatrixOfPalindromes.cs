using System;
using System.Linq;

namespace MatrixOfPalindromes
{
    public class MatrixOfPalindromes
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var matrix = new string[input[0]][];
            for (int row = 0; row < input[0]; row++)
            {
                matrix[row] = new string[input[1]];
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row][col] = $"{alphabet[row]}{alphabet[col+row]}{alphabet[row]}";
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
