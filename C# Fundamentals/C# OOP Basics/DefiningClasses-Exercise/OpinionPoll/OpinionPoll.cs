using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    class OpinionPoll
    {
        static void Main(string[] args)
        {
            var numOfMembers = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < numOfMembers; i++)
            {
                var input = Console.ReadLine().Split();
                var currPerson = new Person();
                currPerson.Name = input[0];
                currPerson.Age = int.Parse(input[1]);
                family.AddMember(currPerson);
            }
            var oldestPerson = family.GetOldestMembers();
            foreach (var mem in oldestPerson)
            {
                Console.WriteLine($"{mem.Name} - {mem.Age}");
            }
        }
    }
}
