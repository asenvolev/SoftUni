using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCustomClassAttribute
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var cmd = Console.ReadLine();

            var attribute = typeof(Weapon).GetCustomAttributes(typeof(CustomAttribute), true)
                .FirstOrDefault() as CustomAttribute;

            while (cmd != "END")
            {
                switch (cmd)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attribute.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Revision: {attribute.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attribute.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attribute.Reviewers)}");
                        break;
                }

                cmd = Console.ReadLine();
            }
        }
    }
}
