using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var create = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var stack = new Stack<string>(create.Skip(1).ToList());
            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (tokens[0])
                {
                    default:
                        break;
                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                    case "Push":
                        stack.Push(tokens.Skip(1).ToArray());
                        break;                    
                }
                input = Console.ReadLine();
            }
            if (stack.Any())
            {
                var sb = new StringBuilder();
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in stack)
                    {
                        sb.AppendLine($"{item}");
                    }
                }
                Console.WriteLine(sb.ToString().Trim());
            }
        }
    }
}
