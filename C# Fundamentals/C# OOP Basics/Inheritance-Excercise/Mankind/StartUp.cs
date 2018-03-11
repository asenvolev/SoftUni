using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var studentInput = Console.ReadLine().Split();

            var studentFirstName = studentInput[0];
            var studentLastName = studentInput[1];
            var facultyNumber = studentInput[2];

            var workerInput = Console.ReadLine().Split();

            var workerFirstName = workerInput[0];
            var workerLastName = workerInput[1];
            var weekSalary = decimal.Parse(workerInput[2]);
            var hoursPerDay = decimal.Parse(workerInput[3]);

            try
            {
                var student = new Student(studentFirstName, studentLastName, facultyNumber);
                var worker = new Worker(workerFirstName, workerLastName, weekSalary, hoursPerDay);
                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
