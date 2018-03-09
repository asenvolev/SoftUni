
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().Trim();
            var dict = new Dictionary<string, string>();
            while (name != "stop")
            {
                string email = Console.ReadLine().Trim();
                string lastChars = email.Substring(email.Length - 2, 2);
                if (lastChars!="us" && lastChars!="uk")
                {
                    if (dict.ContainsKey(name))
                    {
                        dict[name] = email;
                    }
                    else
                    {
                        dict.Add(name, email);
                    }
                }
                name = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
