using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
    public class TowerOfHanoi
    {
        private static int stepsTaken = 0;
        private static Stack<int> source;
        private static Stack<int> destination;
        private static Stack<int> spare;
        public static void Main()
        {
            int bottomDisk = int.Parse(Console.ReadLine());
            source = new Stack<int>(Enumerable.Range(1, bottomDisk).Reverse());
            destination = new Stack<int>();
            spare = new Stack<int>();
            PrintStacks();
            MoveDisks(bottomDisk, source, destination, spare);
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintStacks(); 
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, spare, destination);
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintStacks();
                MoveDisks(bottomDisk - 1, spare, destination, source);
            }
        }

        private static void PrintStacks()
        {
            Console.WriteLine($"Source: {String.Join(", ", source.Reverse())}");
            Console.WriteLine($"Destination: {String.Join(", ", destination.Reverse())}");
            Console.WriteLine($"Spare: {String.Join(", ",spare.Reverse())}");
            Console.WriteLine();
        }
    }
}
