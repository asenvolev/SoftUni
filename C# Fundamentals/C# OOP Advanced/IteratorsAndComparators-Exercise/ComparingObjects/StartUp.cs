using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var people = new List<Person>();
            while (input!="END")
            {
                var tokens = input.Split(' ');
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];
                people.Add(new Person(name, age, town));

                input = Console.ReadLine();
            }
            var index = int.Parse(Console.ReadLine());
            var person = people[index - 1];
            int numOfEqualPeople = people.Count(x => x.CompareTo(person) == 0);
            if (numOfEqualPeople <2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{numOfEqualPeople} {people.Count-numOfEqualPeople} {people.Count}");
            }
        }
    }
}
