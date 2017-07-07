using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnevnaPechalba
{
    class DnevnaPechalba
    {
        static void Main(string[] args)
        {
            var workdays = int.Parse(Console.ReadLine());
            var moneyperday = double.Parse(Console.ReadLine());
            var dollarcost = double.Parse(Console.ReadLine());
            var salary = workdays * moneyperday;
            var bonus = 2.5 * salary;
            var yearsalary = 12 * salary + bonus;
            var tax = yearsalary * 0.25;
            yearsalary -= tax;
            var inleva = yearsalary * dollarcost;
            var levaperday = inleva / 365;
            Console.WriteLine("{0:f2}",levaperday);
        }
    }
}
