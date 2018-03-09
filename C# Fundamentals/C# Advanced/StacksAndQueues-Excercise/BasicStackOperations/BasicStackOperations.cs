using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStackOperations
{
    public class BasicStackOperations
    {
        public static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>(secondInput);
            int numToPush = firstInput[0];
            int numToPop = firstInput[1];
            int numToCheck = firstInput[2];
            if (numToPush == stack.Count)
            {
                for (int i = 0; i < numToPop; i++)
                {
                    stack.Pop();
                }
                if (stack.Contains(numToCheck))
                {
                    Console.WriteLine("true");
                }
                else if(stack.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine("False");
            }
            
        }
    }
}
