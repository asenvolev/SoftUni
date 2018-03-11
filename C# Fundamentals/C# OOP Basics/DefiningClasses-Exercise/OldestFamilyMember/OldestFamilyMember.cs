using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OldestFamilyMember
{
    class OldestFamilyMember
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
            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

        }
    }
}
