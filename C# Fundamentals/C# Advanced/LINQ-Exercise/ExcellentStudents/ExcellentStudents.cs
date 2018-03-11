using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellentStudents
{
    class ExcellentStudents
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<string>();
            while (input != "END")
            {
                list.Add(input);
                input = Console.ReadLine();
            }
            list.Select(x =>
            {

                var tokens = x.Split();
                var firstName = tokens[0];
                var secondName = tokens[1];
                var marks = new List<int>();
                for (int i = 2; i < tokens.Length; i++)
                {
                    marks.Add(int.Parse(tokens[i]));
                }
                return new { firstName, secondName, marks };
            }).Where(x => x.marks.Contains(6))
            .ToList().ForEach(x => Console.WriteLine(x.firstName + " " + x.secondName));
        }
    }
}
