using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var car = 0.0;
            var microbus = 0.0;
            var smallbus = 0.0;
            var bus = 0.0;
            var train = 0.0;
            var allthepeople = 0;
            for (int i = 0; i < n; i++)
            {
                var students = int.Parse(Console.ReadLine());
                if (students<=5)
                {
                    car += students;
                }
                else if (students <=12)
                {
                    microbus += students;
                }
                else if (students <=25)
                {
                    smallbus += students;
                }
                else if (students<=40)
                {
                    bus += students;
                }
                else
                {
                    train += students;
                }
                allthepeople += students;

            }
            Console.WriteLine("{0:f2}%",car/allthepeople*100);
            Console.WriteLine("{0:f2}%",microbus/allthepeople*100);
            Console.WriteLine("{0:f2}%",smallbus/allthepeople*100);
            Console.WriteLine("{0:f2}%",bus/allthepeople*100);
            Console.WriteLine("{0:f2}%",train/allthepeople*100);
        }
    }
}
