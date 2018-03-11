using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundedNumbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).OrderBy(x=>x).ToArray();
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split().Select(int.Parse).Where(w => w >= nums[0] && w <= nums[1]))); 
        }
    }
}
