using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    class StudentsByGroup
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
            Console.WriteLine(string.Join("\n", list.Select(x => x.Split()).Where(x => int.Parse((x[2]).ToString()) == 2).OrderBy(x => x[0])));
        }
    }
}
