using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToList();
            var result = new Dictionary<string, int>();
            var resultOnList = new List<string>();
            foreach (var item in input)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }
                result[item]++;
            }
            input.Clear();
            foreach (var item in result)
            {
                if (item.Value %2!=0)
                {
                    resultOnList.Add(item.Key);
                    
                }
            }
            Console.WriteLine(string.Join(", ", resultOnList));
        }
    }
}
