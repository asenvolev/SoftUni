using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsEnrolledIn2014Or2015
{
    class StudentsEnrolledIn2014Or2015
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
                var facultyNumber = tokens[0];
                var marks = new List<int>();
                for (int i = 1; i < tokens.Length; i++)
                {
                    marks.Add(int.Parse(tokens[i]));
                }
                return new { facultyNumber, marks };
            }).Where(x => x.facultyNumber.EndsWith("14") || x.facultyNumber.EndsWith("15"))
            .ToList().ForEach(x => Console.WriteLine(string.Join(" ",x.marks)));
        }
    }
}
