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
            var result = new Dictionary<string, string>();
            string name = Console.ReadLine();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                email.Reverse();
                if (email[0] == 's' && email[1] == 'u')
                {

                }
                else
                {
                    email.Reverse();
                    if (result.ContainsKey(name))
                    {
                        result[name] = email;
                    }
                    result.Add(name, email);
                }
                name = Console.ReadLine();

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
