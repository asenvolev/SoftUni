using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;
        public string Department => this.department;
        public decimal Salary => this.salary;
        
        public Employee(string Name, decimal Salary, string Position, string Department)
        {
            this.name = Name;
            this.salary = Salary;
            this.position = Position;
            this.department = Department;
            this.email = "n/a";
            this.age = -1;
        }

        public Employee(string Name, decimal Salary, string Position, string Department, string Email)
            : this(Name,Salary,Position,Department)
        {
            this.email = Email;
        }

        public Employee(string Name, decimal Salary, string Position, string Department, int Age)
            : this(Name, Salary, Position, Department)
        {
            this.age = Age;
        }

        public Employee(string Name, decimal Salary, string Position, string Department, string Email, int Age)
            : this(Name, Salary, Position, Department)
        {
            this.email = Email;
            this.age = Age;
        }
        public override string ToString()
        {
            return $"{this.name} {this.salary:f2} {this.email} {this.age}";
        }
    }
}
