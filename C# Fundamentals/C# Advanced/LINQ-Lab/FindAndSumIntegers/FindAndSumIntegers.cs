using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAndSumIntegers
{
    class FindAndSumIntegers
    {
        static void Main(string[] args)
        {
            try
            {
                var array = Console.ReadLine().Split().Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new { value, success };
                }).Where(s => s.success).Select(s => s.value).ToList();
                if (array.Count != 0)
                {
                    Console.WriteLine(array.Sum());
                }
                else
                {
                    Console.WriteLine("No match");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
