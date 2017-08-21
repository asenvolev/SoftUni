using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenturiestoMinutes
{
    class CenturiestoMinutes
    {
        static void Main(string[] args)
        {
            Console.Write("centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes}");
        }
    }
}
