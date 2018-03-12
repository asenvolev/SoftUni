//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class PersonCollectionSlow : IPersonCollection
//{
//    private List<Person> persons = new List<Person>();

//    public bool AddPerson(string email, string name, int age, string town)
//    {
//        if (this.FindPerson(email)!=null)
//        {
//            return false;
//        }
//        var currPerson = new Person()
//        {
//            Email = email, Name = name, Age = age, Town = town
//        };
//        this.persons.Add(currPerson);
//        return true;
//    }

//    public int Count
//    {
//        get
//        {
//            return this.persons.Count;
//        }
//    }

//    public Person FindPerson(string email)
//    {
//        return this.persons.FirstOrDefault(x => x.Email == email);
//    }

//    public bool DeletePerson(string email)
//    {
//        var person = this.FindPerson(email);
//        return this.persons.Remove(person);
//    }

//    public IEnumerable<Person> FindPersons(string emailDomain)
//    {
//        return this.persons.Where(x => x.Email.EndsWith('@'+emailDomain)).OrderBy(p => p.Email);
//    }

//    public IEnumerable<Person> FindPersons(string name, string town)
//    {
//        return this.persons.Where(x => x.Name == name && x.Town==town).OrderBy(p => p.Email);
//    }

//    public IEnumerable<Person> FindPersons(int startAge, int endAge)
//    {
//        return this.persons.Where(x => x.Age>=startAge && x.Age<=endAge)
//            .OrderBy(p => p.Age)
//            .ThenBy(p=> p.Email);
//    }

//    public IEnumerable<Person> FindPersons(
//        int startAge, int endAge, string town)
//    {
//        return this.persons.Where(x => x.Age >= startAge && x.Age <= endAge)
//            .Where(x=>x.Town==town)
//            .OrderBy(p => p.Age)
//            .ThenBy(p => p.Email);
//    }
//}
