using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    public class MaximumElement
    {
        public static void Main(string[] args)
        {
            int cycles = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxStack = new Stack<int>();
            int maxValue = int.MinValue;
            for (int i = 0; i < cycles; i++)
            {
                var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                if (input[0] == 1)
                {
                    if (maxValue<input[1])
                    {
                        maxValue = input[1];
                        maxStack.Push(maxValue);
                    }
                    stack.Push(input[1]);
                }
                else if (input[0] == 2)
                { 
                    var pop = stack.Pop();
                    
                    if (maxStack.Peek() == pop)
                    {
                        maxStack.Pop();
                        if (maxStack.Count > 0)
                        {
                            maxValue = maxStack.Peek();
                        }
                        else
                        {
                            maxValue = int.MinValue;
                        }
                    }
                    
                }
                else if (input[0] == 3)
                {
                    Console.WriteLine(maxStack.Peek());
                }
                
            }
            
            
        }
    }
}
