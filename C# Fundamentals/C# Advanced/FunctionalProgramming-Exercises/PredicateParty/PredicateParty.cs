using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateParty
{
    class PredicateParty
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            if (names.Count ==1 && names[0] == "")
            {
                names.RemoveAll(x=>x=="");
            }
            var command = Console.ReadLine().Split().ToArray();
            while (command[0] != "Party!")
            {
                if (command[0] == "Remove")
                {
                    switch (command[1])
                    {
                        default:
                            break;
                        case "StartsWith":
                            names.RemoveAll(x=>x.StartsWith(command[2]));
                            break;
                        case "Length":
                            names.RemoveAll(x => x.Length == int.Parse(command[2]));
                            break;
                        case "EndsWith":
                            names.RemoveAll(x=>x.EndsWith(command[2]));
                            break;
                    }
                }
                if (command[0] == "Double")
                {
                    switch (command[1])
                    {
                        default:
                            break;
                        case "StartsWith":
                            string[] namesStartsWith = names.Where(x => x.StartsWith(command[2])).ToArray();
                            names.AddRange(namesStartsWith);
                            break;
                        case "Length":
                            string[] namesWithLength = names.Where(x => x.Length == int.Parse(command[2])).ToArray();
                            names.AddRange(namesWithLength);
                            break;
                        case "EndsWith":
                            string[] namesEndsWith = names.Where(x => x.EndsWith(command[2])).ToArray();
                            names.AddRange(namesEndsWith);
                            break;
                    }
                }
                command = Console.ReadLine().Split().ToArray();
            }
            if (names.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", names.OrderBy(x => x))} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}