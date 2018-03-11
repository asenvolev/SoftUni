using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class AppliedArithmetics
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var result = new List<int>();
            string command = Console.ReadLine();
            while (command!="end")
            {
                switch (command)
                {
                    default:
                        break;
                    case "add":
                        list = list.Select(x => x += 1).ToList();
                        break;
                    case "multiply":
                        list = list.Select(x => x *= 2).ToList();
                        break;
                    case "subtract":
                        list = list.Select(x => x -= 1).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", list));
                        break;
                }
                command = Console.ReadLine();
            }

        }
    }
}
