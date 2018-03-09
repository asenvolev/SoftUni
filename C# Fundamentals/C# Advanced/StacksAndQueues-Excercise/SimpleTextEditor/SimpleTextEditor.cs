using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextEditor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (input[0])
                {
                    default:
                        break;
                    case "1":
                        stack.Push(input[1]);
                        break;
                    case "2":
                        int numToRemove = int.Parse(input[1]);
                        string stringToRemove = stack.Peek().Remove(stack.Peek().Length - numToRemove, numToRemove);
                        stack.Push(stringToRemove);
                        break;
                    case "3":
                        int indexOfChar = int.Parse(input[1]);
                        var charArray = stack.Peek().ToCharArray();
                        Console.WriteLine(charArray[indexOfChar-1]);
                        break;
                    case "4":
                        stack.Pop();
                        break;
                }
            }
            
        }
    }
}
