using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber)
            :base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (!value.All(char.IsLetterOrDigit) || value.Length<5 || value.Length>10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");
            return sb.ToString();
        }
    }
}
