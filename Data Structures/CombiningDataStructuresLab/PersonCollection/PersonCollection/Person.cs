using System;

public class Person : IComparable
{
    public string Email { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }

   public int CompareTo(object otherPerson)
    {
        var person = (Person)otherPerson;
        return this.Email.CompareTo(person.Email);
    }
}

