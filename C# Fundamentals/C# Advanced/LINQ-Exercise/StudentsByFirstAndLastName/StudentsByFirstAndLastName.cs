using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByFirstAndLastName
{
    class StudentsByFirstAndLastName
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<string>();
            while (input != "END")
            {
                var tokens = input.Split();
                if (String.Compare(tokens[0], tokens[1]) < 0)
                {
                    list.Add(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n", list));
        }
    }
}

