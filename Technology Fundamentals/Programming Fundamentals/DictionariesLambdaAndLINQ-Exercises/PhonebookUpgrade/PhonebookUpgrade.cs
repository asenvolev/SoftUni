using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var contactList = new SortedDictionary<string, string>();
            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    contactList[input[1]] = input[2];
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
                else if (input[0] == "ListAll")
                {
                    foreach (var item in contactList.ToList())
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
