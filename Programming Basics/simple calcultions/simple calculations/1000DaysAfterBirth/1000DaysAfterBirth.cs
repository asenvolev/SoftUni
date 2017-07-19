using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            date = date.AddDays(999);
            Console.WriteLine(String.Format("{0:dd-MM-yyyy}", date));
        }
    }
}
