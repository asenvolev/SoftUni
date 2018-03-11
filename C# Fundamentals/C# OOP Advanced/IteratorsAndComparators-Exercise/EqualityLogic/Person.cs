using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityLogic
{
    public class Person : IComparable<Person>, IComparer<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

        public int CompareTo(Person other)
        {
            return this.Compare(this, other);
        }

        public int Compare(Person x, Person y)
        {
            if (x.Name.CompareTo(y.Name) != 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            return x.Age.CompareTo(y.Age);
        }
        public override bool Equals(object obj)
        {
            var item = obj as Person;

            if (item == null)
            {
                return false;
            }

            return this.Name.Equals(item.Name) && this.Age.Equals(item.Age);
        }
        public override int GetHashCode()
        {
            return this.Age*this.Name.Length;
        }
    }
}
