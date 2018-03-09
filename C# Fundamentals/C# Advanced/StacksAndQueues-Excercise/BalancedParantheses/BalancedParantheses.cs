using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParantheses
{
    class BalancedParantheses
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var openParantheses = new[] { '(', '[', '{' };
            var closeParantheses = new[] { ')', ']', '}' };
            var openStack = new Stack<char>();
            var closeStack = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (openParantheses.Contains(input[i]))
                {
                    openStack.Push(input[i]);
                }
                else
                {
                    if (openStack.Count==0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (input[i])
                    {
                        default:
                            break;
                        case ')':
                            if (openStack.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case '}':
                            if (openStack.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                        case ']':
                            if (openStack.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
                
            }
            Console.WriteLine("YES");


        }
    }
}
