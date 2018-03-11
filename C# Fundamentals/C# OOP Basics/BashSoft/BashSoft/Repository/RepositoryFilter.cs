using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BashSoft.Exceptions;

namespace BashSoft
{
    public class RepositoryFilter
    {
        public void FilterAndTake(Dictionary<string, double> studentsWithMarks, string wantedFilter, int studentsToTake)
        {
            if (wantedFilter == "excellent")
            {
               FilterAndTake(studentsWithMarks, x => x >= 5, studentsToTake); 
            }
            else if (wantedFilter == "average")
            {
                FilterAndTake(studentsWithMarks, x => x >= 3.5 && x < 5, studentsToTake);
            }
            else if (wantedFilter == "poor")
            {
                FilterAndTake(studentsWithMarks, x => x < 3.5, studentsToTake);
            }
            else
            {
                throw new InvalidStudentFilter();
            }
        }

        private void FilterAndTake(Dictionary<string, double> studentsWithMarks, Predicate<double> givenFilter, int studentsToTake)
        {
            int counter = 0;
            foreach (var username_score in studentsWithMarks)
            {
                if (counter == studentsToTake)
                {
                    break;
                }
                if (givenFilter(username_score.Value))
                {
                    OutputWriter.PrintStudent(username_score);
                    counter++;
                }
                
            }
        }

        //private static double Average(List<int> scoresOnTasks)
        //{
        //    int totalScore = 0;
        //    foreach (var score in scoresOnTasks)
        //    {
        //        totalScore += score;
        //    }

        //    var percentageOfAll = totalScore / (scoresOnTasks.Count * 100);
        //    var mark = percentageOfAll * 4 + 2;

        //    return mark;
        //}
    }
}
