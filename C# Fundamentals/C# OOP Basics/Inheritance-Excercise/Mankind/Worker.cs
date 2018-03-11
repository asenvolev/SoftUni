using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value<=10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value<1 || value>12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }
        public decimal SalaryPerHour()
        {
            return weekSalary / (this.WorkHoursPerDay*5);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {WorkHoursPerDay:f2}")
                .AppendLine($"Salary per hour: {SalaryPerHour():f2}");
            return sb.ToString();
        }
    }
}
