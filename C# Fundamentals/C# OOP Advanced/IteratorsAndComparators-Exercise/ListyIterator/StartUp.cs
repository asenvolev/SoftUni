using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var create = Console.ReadLine().Split(new[] { ' ', '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var iterator = new ListyIterator<string>(create.Skip(1).ToList());
            var input = Console.ReadLine();
            while (input!="END")
            {
                switch (input)
                {
                    default:
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(iterator.Print());
                        }
                        catch (Exception ae)
                        {
                            Console.WriteLine(ae.Message);
                        }
                        break;
                    case "PrintAll":
                        var sb = new StringBuilder();
                        foreach (var item in iterator)
                        {
                            sb.Append($"{item} ");
                        }
                        Console.WriteLine(sb.ToString());
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
