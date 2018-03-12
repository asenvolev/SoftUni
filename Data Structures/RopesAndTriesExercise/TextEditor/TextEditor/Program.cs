using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        ITextEditor textEditor = new TextEditor();
        Dictionary<string, bool> users = new Dictionary<string, bool>();

        var regex = new Regex("\"(.+)\"");
        var input = Console.ReadLine();

        while ((input = Console.ReadLine()) != "end")
        {
            var match = regex.Match(input);

            var commands = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            switch (commands[0])
            {
                case "login":
                    string userName = commands[1];
                    users[userName] = true;
                    textEditor.Login(commands[1]);
                    break;
                case "logout":
                    users[commands[1]] = false;
                    textEditor.Logout(commands[1]);
                    break;
                case "users":
                    if (commands.Length>1)
                    {
                        foreach (var name in textEditor.Users(commands[1]))
                        {
                            Console.WriteLine(name);
                        }

                    }
                    else
                    {
                        foreach (var name in textEditor.Users())
                        {
                            Console.WriteLine(name);
                        }
                    }
                    break;
                default:
                    break;
            }

            var username = commands[0];

            if (!(users.ContainsKey(username) && users[username]))
            {
                continue;
            }

            string str = match.Groups[1].Value;
            switch (commands[1])
            {
                case "insert":
                    textEditor.Insert(username, int.Parse(commands[2]), str);
                    break;
                case "prepend":
                    textEditor.Prepend(username, str);
                    break;
                case "substring":
                    textEditor.Substring(username,
                        int.Parse(commands[2]),
                        int.Parse(commands[3]));
                    break;
                case "delete":
                    textEditor.Delete(username,
                        int.Parse(commands[2]),
                        int.Parse(commands[3]));
                    break;
                case "clear":
                    textEditor.Clear(username);
                    break;
                case "length":
                    Console.WriteLine(textEditor.Length(username));
                    break;
                case "print":
                    Console.WriteLine(textEditor.Print(username));
                    break;
                case "undo":
                    textEditor.Undo(username);
                    break;
            }
        }
    }
}

