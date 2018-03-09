using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    public class SoftUniParty
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var reserations = new SortedSet<string>();
            while (input != "PARTY")
            {
                reserations.Add(input);
                input = Console.ReadLine();
            }
            while (input != "END")
            {
                reserations.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine(reserations.Count);
            foreach (var res in reserations)
            {
                Console.WriteLine(res);
            }
        }
    }
}
