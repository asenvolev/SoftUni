using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var students = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < students; i++)
            {
                string name = Console.ReadLine();
                var grades = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
                dict.Add(name, grades);
            }
            foreach (var stud in dict)
            {
                Console.WriteLine($"{stud.Key} is graduated with {stud.Value.Average()}");
            }
        }
    }
}
