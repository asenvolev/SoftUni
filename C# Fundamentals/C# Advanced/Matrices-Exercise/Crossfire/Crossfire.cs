using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossfire
{
    public class Crossfire
    {
        public static void Main()
        {
            var size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new List<List<int>>();
            int counter = 1;

            for (int row = 0; row < size[0]; row++)
            {
                matrix.Add(new List<int>());
                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row].Add(counter);
                    counter++;
                }
            }
            var line = Console.ReadLine();
            while (line != "Nuke it from orbit")
            {
                var input = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int rowBlow = input[0];
                int colBlow = input[1];
                int radius = input[2];

                for (int row = rowBlow - radius; row <= rowBlow + radius; row++)
                {
                    if (row >= 0 && row < matrix.Count && colBlow >= 0 && colBlow < matrix[row].Count)
                    {
                        matrix[row][colBlow] = -1;
                    }
                }
                for (int col = colBlow - radius; col <= colBlow + radius; col++)
                {
                    if (col >= 0 && col < matrix[rowBlow].Count && rowBlow >= 0 && rowBlow < matrix.Count)
                    {
                        matrix[rowBlow][col] = -1;
                    }
                }

                for (int row = matrix.Count - 1; row >= 0; row--)
                {
                    for (int col = matrix[row].Count - 1; col >= 0; col--)
                    {
                        if (matrix[row][col] == -1)
                        {
                            matrix[row].RemoveAt(col);
                        }
                    }
                    if (matrix[row].Count == 0)
                    {
                        matrix.RemoveAt(row);
                    }
                }

                line = Console.ReadLine();
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }
    }
}