using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var letters = Console.ReadLine().Split().OrderBy(x=>x);
            string firstName = null;
            foreach (var character in letters)
            {
                if (firstName == null)
                {
                    firstName = names.FirstOrDefault(x => x.ToLower().StartsWith(character.ToLower()));
                }
                else
                {
                    break;
                }
            }
            if (firstName == null)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(firstName);
            }
            
        }
    }
}
