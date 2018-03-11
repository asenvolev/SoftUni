using System;
using System.Collections.Generic;

namespace BashSoft.Contracts
{
    public interface IStudent : IComparable<IStudent>
    {
        string UserName { get; }
        IReadOnlyDictionary<string, double> MarksByCourseName { get; }
        IReadOnlyDictionary<string, ICourse> EnrolledCourses { get; }

        void SetMarksOnCourse(string courseName, params int[] scores);

        void EnrollInCourse(ICourse course);
    }
}