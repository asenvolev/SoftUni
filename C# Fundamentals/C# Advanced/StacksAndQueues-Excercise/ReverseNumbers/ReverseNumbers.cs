using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    public class ReverseNumbers
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);
            while(stack.Count !=0)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}
