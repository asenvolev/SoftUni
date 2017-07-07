using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var doctors = 7;
            var treated = 0;
            var untreated = 0;
            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && treated<untreated)
                {
                    ++doctors;
                }
                var patients = int.Parse(Console.ReadLine());
                if (patients>doctors)
                {
                    untreated += (patients - doctors);
                    treated += doctors;
                }
                else
                {
                    treated += patients;
                }
            }
            
            Console.WriteLine("Treated patients: {0}.\nUntreated patients: {1}.",treated,untreated);
        }
    }
}
