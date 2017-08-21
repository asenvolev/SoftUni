using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class AppendLists
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToArray();
            var result = new List<string>();
            Array.Reverse(input);
            foreach (var token in input)
            {
                string[] numbers = token.Split(' ');
                foreach (var item in numbers)
                {
                    
                    if (item!=" ")
                    {
                        result.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
