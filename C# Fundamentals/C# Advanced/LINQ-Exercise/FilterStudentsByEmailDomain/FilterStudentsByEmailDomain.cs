using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsByEmailDomain
{
    class FilterStudentsByEmailDomain
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
                var email = tokens[2];
                return new { firstName, secondName, email };
            }).Where(x => x.email.EndsWith("gmail.com"))
            .ToList().ForEach(x => Console.WriteLine(x.firstName + " " + x.secondName));
        }
    }
}
