using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var contactList = new Dictionary<string, string>();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    contactList[input[1]]= input[2];
                }
                else if (input[0] == "S")
                {
                    if (contactList.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {contactList[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
