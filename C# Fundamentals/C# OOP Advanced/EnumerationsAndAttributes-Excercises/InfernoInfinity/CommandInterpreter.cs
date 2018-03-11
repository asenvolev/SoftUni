using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfernoInfinity
{
    public class CommandInterpreter
    {
        Repository repository = new Repository();
        public void StartReadingCommands()
        {
            var input = Console.ReadLine();
            while (input!="END")
            {
                var tokens = input.Split(';').ToList();
                string command = tokens[0];
                tokens.Remove(command);
                switch (command)
                {
                    default:
                        break;
                    case "Create":
                        repository.Create(tokens);
                        break;
                    case "Add":
                        repository.Add(tokens);
                        break;
                    case "Remove":
                        repository.Remove(tokens);
                        break;
                    case "Print":
                        Console.WriteLine(repository.Print(tokens));
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
