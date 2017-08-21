using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToList();
            var countList = new List<int>(1000);
            var dict = new Dictionary<string, int>();
            nums.Sort();
            foreach (var item in nums)
            {
                if (!dict.ContainsKey(item))
                {
                    dict[item]=0;
                }
                dict[item]++;
                Console.WriteLine($"{dict.Keys} -> {dict.Values}");
            }
            
        }
    }
}
