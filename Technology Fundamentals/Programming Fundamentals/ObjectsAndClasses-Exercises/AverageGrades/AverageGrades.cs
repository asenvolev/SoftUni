using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new List<Student>();
            Student currStudent = new Student()
            {
                Name="",
                Grades = new List<double>()
            };

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                currStudent.Name = input[0];
                for (int j = 1; j < input.Length; j++)
                {
                    currStudent.Grades.Add(double.Parse(input[j]));
                }
                if (currStudent.AverageGrades>=5.00)
                {
                    result.Add(currStudent);
                }
                currStudent = new Student()
                {
                    Name = "",
                    Grades = new List<double>()
                };
            }
            var finalResult =result
                .Where(s => s.AverageGrades >=5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrades);
            foreach (var item in finalResult)
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrades:f2}");
            }
        }
    }
}
