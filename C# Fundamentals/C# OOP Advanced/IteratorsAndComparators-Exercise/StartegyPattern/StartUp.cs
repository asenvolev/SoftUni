using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartegyPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numOfInput = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            for (int i = 0; i < numOfInput; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(new Person(name, age));
            }
            var peopleByName = new SortedSet<Person>(people, new NameComparer());
            var peopleByAge = new SortedSet<Person>(people, new AgeComparer());
            var sb = new StringBuilder();
            foreach (var person in peopleByName)
            {
                sb.Append(person + Environment.NewLine);
            }
            foreach (var person in peopleByAge)
            {
                sb.Append(person + Environment.NewLine);
            }
            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
