using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMatrixRotation
{
    public class StringMatrixRotation
    {
        public static void Main()
        {
            var inputRotation = Console.ReadLine().Split(new[] { ' ', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int rotation = int.Parse(inputRotation[1]);
            var queue = new Queue<string>();
            string word = Console.ReadLine();
            int longestWord = 0;
            
            while (word !="END")
            {
                if (word.Length > longestWord)
                {
                    longestWord = word.Length;
                }
                queue.Enqueue(word);
                word = Console.ReadLine();
            }
            var matrix = new char[queue.Count][];
            
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[longestWord];
                var charArray = queue.Dequeue().ToCharArray();
                for (int col = 0; col < longestWord; col++)
                {
                    if (col >= charArray.Length)
                    {
                        matrix[row][col] = ' ';
                    }
                    else
                    {
                        matrix[row][col] = charArray[col];
                    }
                }
            }
            var verticalMatrix = new char[longestWord][];
            var horizontalMatrix = new char[matrix.Length][];
            if (rotation%360!=0)
            {
                rotation = rotation % 360;
                if (rotation == 90)
                {
                    verticalMatrix = RotateMatrix90(matrix, longestWord, matrix.Length);
                    foreach (var row in verticalMatrix)
                    {
                        Console.WriteLine(string.Join("", row));
                    }
                }
                else if (rotation == 180)
                {
                    horizontalMatrix = RotateMatrix180(matrix, matrix.Length, longestWord);
                    foreach (var row in horizontalMatrix)
                    {
                        Console.WriteLine(string.Join("", row));
                    }
                }
                else if (rotation == 270)
                {
                    verticalMatrix = RotateMatrix90(matrix, longestWord, matrix.Length);
                    horizontalMatrix = RotateMatrix180(verticalMatrix, longestWord, matrix.Length);
                    foreach (var row in horizontalMatrix)
                    {
                        Console.WriteLine(string.Join("", row));
                    }
                }
            }
            else
            {
                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join("", row));
                }
            }
            
        }

        public static char[][] RotateMatrix180(char[][] matrix, int row, int col)
        {
            var tempMatrix = new char[row][];
            for (int r = 0; r < row; r++)
            {
                tempMatrix[r] = new char[col];
                for (int c = col - 1; c >= 0; c--)
                {
                    tempMatrix[r][col-1-c] = matrix[row-1 - r][c];
                }
            }
            return tempMatrix;
        }

        public static char[][] RotateMatrix90(char[][] matrix, int row, int col)
        {
            char[][] ret = new char[row][];

            for (int i = 0; i < row; ++i)
            {
                ret[i] = new char[col];
                for (int j = 0; j < col; ++j)
                {
                    ret[i] [j] = matrix[j][i];
                }
                Array.Reverse(ret[i]);
            }

            return ret;
        }
    }
}
