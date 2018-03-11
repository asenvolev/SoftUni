using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;
    public Person(string firstName, string lastName, int age, double salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }
    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"{nameof(FirstName)} cannot be less than 3 symbols");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException($"{nameof(LastName)} cannot be less than 3 symbols");
            }
            this.lastName = value;
        }
    }
    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException($"{nameof(Age)} cannot be zero or negative integer");
            }
            this.age = value;
        }
    }
    public double Salary
    {
        get { return this.salary; }
        private set
        {
            if (value < 460)
            {
                throw new ArgumentException($"{nameof(Salary)} cannot be less than 460 leva");
            }
            this.salary = value;
        }
    }
    
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
    }
}
