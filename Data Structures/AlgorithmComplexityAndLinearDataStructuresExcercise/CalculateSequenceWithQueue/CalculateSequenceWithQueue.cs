using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateSequenceWithQueue
{
    public class CalculateSequenceWithQueue
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var queue = new Queue<int>();
            var secQueue = new Queue<int>();

            queue.Enqueue(input);
            secQueue.Enqueue(input);

            for (int i = 0; i < 18; i++)
            {
                var currNum = secQueue.Dequeue();
                queue.Enqueue(currNum + 1);
                if (queue.Count==50)
                {
                    break;
                }
                secQueue.Enqueue(currNum + 1);
                queue.Enqueue(2*currNum + 1);
                secQueue.Enqueue(2*currNum + 1);
                queue.Enqueue(currNum + 2);
                secQueue.Enqueue(currNum + 2);
            }

            Console.WriteLine(string.Join(", ",queue));
        }
    }
}
