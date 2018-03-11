﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using BashSoft.Models;
using BashSoft.Exceptions;
using System.Linq;

namespace BashSoft
{
    public class StudentsRepository
    {
        private bool isDataInilized = false;
        private Dictionary<string, Dictionary<string, double>> studentsByCourse;
        private Dictionary<string, Student> students;
        private Dictionary<string, Course> courses;
        private RepositoryFilter filter;
        private RepositorySorter sorter;
        public StudentsRepository(RepositorySorter sorter, RepositoryFilter filter)
        {
            this.sorter = sorter;
            this.filter = filter;
            this.studentsByCourse = new Dictionary<string, Dictionary<string, double>>();
        }
        public void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = studentsByCourse[courseName].Count;
                }
                Dictionary<string, double> marks = this.courses[courseName].StudentsByName.ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);
                this.filter.FilterAndTake(marks, givenFilter, studentsToTake.Value);
            }
        }

        public void OrderAndTake(string courseName, string comparison, int? studentsToTake = null)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = this.courses[courseName].StudentsByName.Count;
                }
                Dictionary<string, double> marks = this.courses[courseName].StudentsByName.ToDictionary(x => x.Key, x => x.Value.MarksByCourseName[courseName]);
                this.sorter.OrderAndTake(marks, comparison, studentsToTake.Value);
            }
        }

        public void LoadData(string fileName)
        {
            if (this.isDataInilized)
            {
                throw new DataAlreadyInitialisedException();
            }
            this.students = new Dictionary<string, Student>();
            this.courses = new Dictionary<string, Course>();
            ReadData(fileName);
        }
        public void UnloadData()
        {
            if (!this.isDataInilized)
            {
                throw new DataNotInitializedException();
            }
            this.students = null;
            this.courses = null;
            this.isDataInilized = false;
        }
        private void ReadData(string fileName)
        {
            string path = SessionData.currentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                var rgx = new Regex(@"([A-Z][a-zA-Z#\++]*_[A-Z][a-z]{2}_\d{4})\s+([A-Za-z]+\d{2}_\d{2,4})\s([\s0-9]+)");
                var allInputLines = File.ReadAllLines(path);
                for (int i = 0; i < allInputLines.Length; i++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[i]) && rgx.IsMatch(allInputLines[i]))
                    {
                        var currentMatch = rgx.Match(allInputLines[i]);
                        var courseName = currentMatch.Groups[1].Value;
                        var studentName = currentMatch.Groups[2].Value;
                        var scoreStr = currentMatch.Groups[3].Value;
                        try
                        {
                            int[] scores = scoreStr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse).ToArray();
                            if (scores.Any(x=>x>100 || x<0))
                            {
                                OutputWriter.DisplayException(ExceptionMessages.InvalidNumberOfScores);
                                continue;
                            }
                            if (!this.students.ContainsKey(studentName))
                            {
                                this.students.Add(studentName, new Student(studentName));
                            }
                            if (!this.courses.ContainsKey(courseName))
                            {
                                this.courses.Add(courseName, new Course(courseName));
                            }
                            Course course = this.courses[courseName];
                            Student student = this.students[studentName];
                            student.EnrollInCourse(course);
                            student.SetMarksOnCourse(courseName, scores);
                            course.EnrollStudent(student);
                        }
                        catch (FormatException fex)
                        {
                            throw new ArgumentException(fex.Message + $"at line : {allInputLines[i]}");
                        }
                    }
                }
            }
            else
            {
                throw new InvalidPathException();
            }

            isDataInilized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInilized)
            {
                if (this.courses.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    throw new InexistingCourseInDataBaseException();
                }
            }
            else
            {
                throw new DataNotInitializedException();
            }

            return false;
        }

        private bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && this.courses[courseName].StudentsByName.ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public void GetStudentScoresFromCourse(string courseName, string username)
        {
            OutputWriter.PrintStudent(
                new KeyValuePair<string, double>(username, this.courses[courseName].StudentsByName[courseName].MarksByCourseName[courseName]));
        }

        public void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}");
                foreach (var studetMarksEntry in this.courses[courseName].StudentsByName)
                {
                    this.GetStudentScoresFromCourse(courseName, studetMarksEntry.Key);
                }
            }
        }
    }
}