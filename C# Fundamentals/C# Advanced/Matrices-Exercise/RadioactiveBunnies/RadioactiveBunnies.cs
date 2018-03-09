using System;
using System.Linq;

namespace RadioactiveBunnies
{
    public class RadioactiveBunnies
    {
        public static void Main()
        {
            var size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var matrix = new char[size[0]][];
            var tempMatrix = new char[size[0]][];
            int playerRow = -1;
            int playerCol = -1;

            for (int row = 0; row < matrix.Length; row++)
            {
                string input = Console.ReadLine();
                int playerColumn = input.IndexOf('P');
                if (playerColumn!=-1)
                {
                    playerCol = playerColumn;
                    playerRow = row;
                }
                matrix[row] = input.ToCharArray();
            }

            var comands = Console.ReadLine().ToCharArray();
            bool died = false;
            bool won = false;
            for (int i = 0; i < comands.Length; i++)
            {
                switch (comands[i])
                {
                    default:
                        break;
                    case 'L':
                        if (playerCol == 0)
                        {
                            won = true;
                            matrix[playerRow][playerCol] = '.';
                        }
                        else if (matrix[playerRow][playerCol - 1] == '.')
                        {
                            matrix[playerRow][playerCol - 1] = 'P';
                            matrix[playerRow][playerCol] = '.';
                            playerCol--;
                        }
                        else if (matrix[playerRow][playerCol - 1] == 'B')
                        {
                            died = true;
                            playerCol--;
                        }
                        break;
                    case 'R':
                        if (playerCol == matrix[playerRow].Length - 1)
                        {
                            won = true;
                            matrix[playerRow][playerCol] = '.';
                        }
                        else if (matrix[playerRow][playerCol + 1] == '.')
                        {
                            matrix[playerRow][playerCol + 1] = 'P';
                            matrix[playerRow][playerCol] = '.';
                            playerCol++;
                        }
                        else if (matrix[playerRow][playerCol + 1] == 'B')
                        {
                            died = true;
                            playerCol++;
                        }
                        break;
                    case 'D':
                        if (playerRow == matrix.Length - 1)
                        {
                            won = true;
                            matrix[playerRow][playerCol] = '.';
                        }
                        else if (matrix[playerRow + 1][playerCol] == '.')
                        {
                            matrix[playerRow + 1][playerCol] = 'P';
                            matrix[playerRow][playerCol] = '.';
                            playerRow++;
                        }
                        else if (matrix[playerRow + 1][playerCol] == 'B')
                        {
                            died = true;
                            playerRow++;
                        }
                        break;
                    case 'U':
                        if (playerRow == 0)
                        {
                            won = true;
                            matrix[playerRow][playerCol] = '.';
                        }
                        else if (matrix[playerRow - 1][playerCol] == '.')
                        {
                            matrix[playerRow - 1][playerCol] = 'P';
                            matrix[playerRow][playerCol] = '.';
                            playerRow--;
                        }
                        else if (matrix[playerRow - 1][playerCol] == 'B')
                        {
                            died = true;
                            playerRow--;
                        }
                        break;
                }
                for (int row = 0; row < tempMatrix.Length; row++)
                {
                    tempMatrix[row] = new char[size[1]];
                    for (int col = 0; col < tempMatrix[row].Length; col++)
                    {
                        tempMatrix[row][col] = matrix[row][col];
                    }
                }

                for (int row = 0; row < tempMatrix.Length; row++)
                {
                    for (int col = 0; col < tempMatrix[row].Length; col++)
                    {
                        if (matrix[row][col] == 'B')
                        {
                            if (row > 0)
                            {
                                if (matrix[row - 1][col] == 'P')
                                {
                                    died = true;
                                }
                                tempMatrix[row - 1][col] = 'B';
                            }
                            if (row < matrix.Length - 1)
                            {
                                if (matrix[row + 1][col] == 'P')
                                {
                                    died = true;
                                }
                                tempMatrix[row + 1][col] = 'B';
                            }
                            if (col < matrix[row].Length - 1)
                            {
                                if (matrix[row][col + 1] == 'P')
                                {
                                    died = true;
                                }
                                tempMatrix[row][col + 1] = 'B';
                            }
                            if (col > 0)
                            {
                                if (matrix[row][col - 1] == 'P')
                                {
                                    died = true;
                                }
                                tempMatrix[row][col - 1] = 'B';
                            }
                        }
                    }
                }
                
                for (int row = 0; row < tempMatrix.Length; row++)
                {
                    for (int col = 0; col < tempMatrix[row].Length; col++)
                    {
                        matrix[row][col] = tempMatrix[row][col];
                    }
                }
                if (won)
                {
                    died = false;
                    break;
                }
                if (died)
                {
                    break;
                }
            }
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("",row));
            }
            if (won)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if(died)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }
    }
}
