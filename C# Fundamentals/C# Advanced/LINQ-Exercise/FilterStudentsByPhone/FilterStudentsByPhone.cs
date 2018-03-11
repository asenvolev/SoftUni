using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterStudentsByPhone
{
    class FilterStudentsByPhone
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
                var phone = tokens[2];
                return new { firstName, secondName, phone };
            }).Where(x => x.phone.StartsWith("02") || x.phone.StartsWith("+3592"))
            .ToList().ForEach(x => Console.WriteLine(x.firstName + " " + x.secondName));
        }
    }
}
