using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>(secondInput);
            int numToEnqueue = firstInput[0];
            int numToDequeue = firstInput[1];
            int numToCheck = firstInput[2];
            if (numToEnqueue == queue.Count)
            {
                for (int i = 0; i < numToDequeue; i++)
                {
                    queue.Dequeue();
                }
                if (queue.Contains(numToCheck))
                {
                    Console.WriteLine("true");
                }
                else if (queue.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
