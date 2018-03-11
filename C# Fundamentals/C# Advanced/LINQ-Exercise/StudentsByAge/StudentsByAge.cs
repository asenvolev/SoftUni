using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByAge
{
    class StudentsByAge
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<string>();
            while (input != "END")
            {
                var tokens = input.Split();
                if (int.Parse(tokens[2])<=24 && int.Parse(tokens[2]) >= 18)
                {
                    list.Add(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n", list));
        }
    }
}
