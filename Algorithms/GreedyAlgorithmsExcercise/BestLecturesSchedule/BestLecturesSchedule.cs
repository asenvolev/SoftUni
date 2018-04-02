using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestLecturesSchedule
{
    public class BestLecturesSchedule
    {
        public static void Main()
        {
            var lecturesCount = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).First();
            var sb = new StringBuilder();
            var lectures = new List<Lecture>();
            int possibleLectures = 1;

            for (int i = 0; i < lecturesCount; i++)
            {
                var lecture = Console.ReadLine().Split(new[] { ' ', '-', ':'}, StringSplitOptions.RemoveEmptyEntries);
                lectures.Add(new Lecture(lecture[0], int.Parse(lecture[1]), int.Parse(lecture[2])));
            }

            lectures = lectures.OrderBy(x => x.EndTime).ToList();
            var last = lectures.First();
            sb.AppendLine($"{last.StartTime}-{last.EndTime} -> {last.Name}");

            for (int i = 1; i < lectures.Count; i++)
            {
                var currentLecture = lectures[i];
                if (currentLecture.StartTime>=last.EndTime)
                {
                    last = currentLecture;
                    sb.AppendLine($"{last.StartTime}-{last.EndTime} -> {last.Name}");
                    possibleLectures++;
                }
            }
            Console.WriteLine($"Lectures ({possibleLectures}):");
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }

    public class Lecture
    {
        public Lecture(string name, int startTime, int endTime)
        {
            this.Name = name;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public string Name { get; set; }

        public int StartTime { get; set; }

        public int EndTime { get; set; }
    }
}
