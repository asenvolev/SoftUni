using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string dateText = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateText, "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
