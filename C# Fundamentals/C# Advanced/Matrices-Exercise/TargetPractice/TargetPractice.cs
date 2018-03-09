using System;
using System.Linq;

namespace TargetPractice
{
    public class TargetPractice
    {
        public static void Main()
        {
            var size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var word = Console.ReadLine().ToCharArray();
            int counter = 0;
            var matrix = new char[size[0]][];
            var switcher = true;
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowBlow = input[0];
            int colBlow = input[1];
            int radius = input[2];
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                matrix[row] = new char[size[1]];
                if (switcher)
                {
                    for (int col = size[1] - 1; col >= 0; col--)
                    {
                        matrix[row][col] = word[counter];
                        if (counter == word.Length - 1)
                        {
                            counter = 0;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    switcher = false;
                }
                else
                {
                    for (int col = 0; col < size[1]; col++)
                    {
                        matrix[row][col] = word[counter];
                        if (counter == word.Length - 1)
                        {
                            counter = 0;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    switcher = true;
                }
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                    if ((col - colBlow)*(col - colBlow) + (row - rowBlow)* (row - rowBlow) <= radius*radius)
                    {
                        matrix[row][col] = ' ';
                    }
                }
            }
            
            for (int col = 0; col < size[1]; col++)
            {
                
                while (true)
                {
                    bool gravity = false;
                    for (int row = 0; row < matrix.Length-1; row++)
                    {
                        var currChar = matrix[row][col];
                        var botChar = matrix[row + 1][col];
                        if (currChar != ' ' && botChar == ' ')
                        {
                            matrix[row + 1][col] = currChar;
                            matrix[row][col] = ' ';
                            gravity = true;
                        }
                    }
                    if (!gravity)
                    {
                        break;
                    }
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }
    }
}
