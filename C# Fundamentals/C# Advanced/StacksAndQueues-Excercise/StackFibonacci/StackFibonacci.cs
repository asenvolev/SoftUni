using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            
            for (int i = 0; i <= n; i++)
            {
                if (i==0 || i ==1)
                {
                    stack.Push(i);
                }
                else
                {
                    long firstNum = stack.Pop();
                    long secNum = stack.Pop();
                    long currNum = firstNum + secNum;
                    stack.Push(secNum);
                    stack.Push(firstNum);
                    stack.Push(currNum);
                }
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
