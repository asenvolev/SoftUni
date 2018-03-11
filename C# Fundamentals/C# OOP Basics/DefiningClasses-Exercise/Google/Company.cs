using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class Company
    {
        private string name;
        private string department;
        private decimal salary;
        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public string Name => this.name;
        public string Department => this.department;
        public decimal Salary => this.salary;
    }
}
