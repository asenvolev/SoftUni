using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithQueue
{
    public class SequenceWithQueue
    {
        public static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());
            var queue = new Queue<long>();
            queue.Enqueue(input);
            for (int i = 0; i < 50; i++)
            {
                long currentSeq = queue.Dequeue();
                long FirstToEnqueue = currentSeq + 1;
                queue.Enqueue(FirstToEnqueue);
                long secondToEnqueue = 2 * currentSeq + 1;
                queue.Enqueue(secondToEnqueue);
                long thirdToEnqueue = currentSeq + 2;
                queue.Enqueue(thirdToEnqueue);
                Console.Write(currentSeq+" ");
            }
        }
    }
}
