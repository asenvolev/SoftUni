using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortEvenNumbers
{
    class SortEvenNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ",Console.ReadLine().Split(new[] { ' ',',' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray().Where(x=>x%2==0).OrderBy(x=>x)));
        }
    }
}
