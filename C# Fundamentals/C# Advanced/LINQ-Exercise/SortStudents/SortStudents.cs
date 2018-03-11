using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStudents
{
    class SortStudents
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
                return new { firstName, secondName };
            }).OrderBy(x => x.secondName).
            ThenByDescending(f => f.firstName)
            .ToList().ForEach(x => Console.WriteLine(x.firstName+" "+x.secondName));
        }
    }
}
