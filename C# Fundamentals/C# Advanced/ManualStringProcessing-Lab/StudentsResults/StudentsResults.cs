using System;
using System.Linq;

namespace StudentsResults
{
    public class StudentsResults
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average");
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { '-', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var studentName = input[0];
                var cAdv = double.Parse(input[1]);
                var cOOP = double.Parse(input[2]);
                var advOOP = double.Parse(input[3]);
                var average = (cAdv + cOOP + advOOP) / 3;

                Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|", studentName, cAdv, cOOP, advOOP, average);
            }
        }
    }
}
