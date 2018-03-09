using System;
using System.Linq;

namespace LegoBlocks
{
    public class LegoBlocks
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var firstMatrix = new int[n][];
            var secondMatrix = new int[n][];
            bool equal = true;

            for (int row = 0; row < firstMatrix.Length; row++)
            {
                firstMatrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                secondMatrix[row] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int row = 0; row < firstMatrix.Length-1; row++)
            {
                if (firstMatrix[row].Length + secondMatrix[row].Length != firstMatrix[row+1].Length + secondMatrix[row+1].Length)
                {
                    equal = false;
                }
            }

            if (equal)
            {
                for (int row = 0; row < n; row++)
                {
                    Array.Reverse(secondMatrix[row]);
                    Console.Write($"[{string.Join(", ", firstMatrix[row])}, {string.Join(", ", secondMatrix[row])}]");
                    Console.WriteLine();
                }
                
            }
            else
            {
                int sum = 0;
                for (int row = 0; row < n; row++)
                {
                    sum += firstMatrix[row].Length + secondMatrix[row].Length;
                }
                Console.WriteLine($"The total number of cells is: {sum}");
            }
        }
    }
}
