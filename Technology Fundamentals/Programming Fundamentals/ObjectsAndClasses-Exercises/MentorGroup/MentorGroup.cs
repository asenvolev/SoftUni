using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {
            string inputDates = Console.ReadLine();
            var listOfStudents = new List<Student>();
            while (inputDates != "end of dates")
            {
                string[] splitter = inputDates.Split();
                string currUserName = splitter[0];
                var currAttendDates = splitter[1].Split(',').Select(s => DateTime.ParseExact(s, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                Student currStudent = new Student
                {
                    Name = currUserName,
                    attendDates = currAttendDates,
                    comments = new List<string>()
                };
                listOfStudents.Add(currStudent);
                inputDates = Console.ReadLine();

            }
            string[] inputComments = Console.ReadLine().Split('-');
            while (inputComments[0] != "end of comments")
            {
                foreach (var item in listOfStudents)
                {
                    if (item.Name == inputComments[0])
                    {
                        item.comments.Add(inputComments[1]);
                    }
                }
                inputComments = Console.ReadLine().Split('-');
            }
            var sortedList = listOfStudents.OrderBy(a => a.Name).ThenBy(a => a.attendDates);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Name + "\nComments:");
                if (item.comments.Count != 0)
                {
                    foreach (var comment in item.comments.OrderBy(x => x))
                    {
                        Console.WriteLine("- " + string.Join("\n- ", comment));

                    }
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in item.attendDates.OrderBy(x => x))
                {
                    Console.WriteLine("-- " + string.Join("\n-- ", date.ToString("dd/MM/yyyy")));
                }
            }

        }
    }
}