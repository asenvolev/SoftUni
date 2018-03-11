using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyReservationFilterModule
{
    class PartyReservationFilterModule
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            var recycleBin = new List<string>();
            if (names.Count == 1 && names[0] == "")
            {
                names.RemoveAll(x => x == "");
            }
            var command = Console.ReadLine().Split(';').ToArray();
            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    switch (command[1])
                    {
                        default:
                            break;
                        case "Starts with":
                            recycleBin.AddRange(names.Where(x => x.StartsWith(command[2])));
                            names.RemoveAll(x => x.StartsWith(command[2]));
                            break;
                        case "Length":
                            recycleBin.AddRange(names.Where(x => x.Length == int.Parse(command[2])));
                            names.RemoveAll(x => x.Length == int.Parse(command[2]));
                            break;
                        case "Ends with":
                            recycleBin.AddRange(names.Where(x => x.EndsWith(command[2])));
                            names.RemoveAll(x => x.EndsWith(command[2]));
                            break;
                        case "Contains":
                            recycleBin.AddRange(names.Where(x => x.Contains(command[2])));
                            names.RemoveAll(x => x.Contains(command[2]));
                            break;
                    }
                }
                if (command[0] == "Remove filter")
                {
                    switch (command[1])
                    {
                        default:
                            break;
                        case "Starts with":
                            names.AddRange(recycleBin.Where(x => x.StartsWith(command[2])));
                            break;
                        case "Length":
                            names.AddRange(recycleBin.Where(x => x.Length == int.Parse(command[2])));
                            break;
                        case "Ends with":
                            string[] namesEndsWith = names.Where(x => x.EndsWith(command[2])).ToArray();
                            names.AddRange(recycleBin.Where(x => x.EndsWith(command[2])));
                            break;
                        case "Contains":
                            names.AddRange(recycleBin.Where(x => x.Contains(command[2])));
                            break;
                    }
                }
                command = Console.ReadLine().Split(';').ToArray();
            }
            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(" ", names)}");
            }
        }
    }
}
