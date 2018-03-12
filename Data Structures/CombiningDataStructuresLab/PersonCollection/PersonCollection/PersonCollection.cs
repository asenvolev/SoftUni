using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

public class PersonCollection : IPersonCollection
{
    private Dictionary<string, Person> personsByEmail = new Dictionary<string, Person>();
    private Dictionary<string, SortedSet<Person>> personsByEmailDomain = new Dictionary<string, SortedSet<Person>>();
    private Dictionary<string, SortedSet<Person>> personsByNameAndTown = new Dictionary<string, SortedSet<Person>>();
    private OrderedDictionary<int, SortedSet<Person>> personsByAge = new OrderedDictionary<int, SortedSet<Person>>();
    private Dictionary<string, OrderedDictionary<int, SortedSet<Person>>> personsByTownAndAge = new Dictionary<string, OrderedDictionary<int, SortedSet<Person>>>();


    public bool AddPerson(string email, string name, int age, string town)
    {
        if (this.FindPerson(email) != null)
        {
            return false;
        }
        var currPerson = new Person()
        {
            Email = email,
            Name = name,
            Age = age,
            Town = town
        };
        this.personsByEmail.Add(email, currPerson);
        this.AddByDomain(email, currPerson);
        this.AddByNameAndTown(currPerson);
        this.AddByAge(currPerson);
        this.AddByTown(currPerson);
        return true;
    }

    private string CombineNameAndTown(string name, string town)
    {
        const string separator = "|!|";
        return name + separator + town;
    }

    private void AddByDomain(string email, Person person)
    {
        string domain = email.Split('@')[1];

        if (!this.personsByEmailDomain.ContainsKey(domain))
        {
            this.personsByEmailDomain[domain] = new SortedSet<Person>();
        }

        this.personsByEmailDomain[domain].Add(person);
    }

    private void AddByAge(Person person)
    {
        int age = person.Age;

        if (!this.personsByAge.ContainsKey(age))
        {
            this.personsByAge[age] = new SortedSet<Person>();
        }

        this.personsByAge[age].Add(person);
    }

    private void AddByNameAndTown(Person person)
    {
        string nameAndTown = this.CombineNameAndTown(person.Name, person.Town);

        this.personsByNameAndTown.AppendValueToKey(nameAndTown, person);
    }

    private void AddByTown(Person person)
    {
        string town = person.Town;
        int age = person.Age;
        if (!this.personsByTownAndAge.ContainsKey(town))
        {
            this.personsByTownAndAge[town] = new OrderedDictionary<int, SortedSet<Person>>();
        }

        if (!this.personsByTownAndAge[town].ContainsKey(age))
        {
            this.personsByTownAndAge[town][age] = new SortedSet<Person>();
        }

        this.personsByTownAndAge[town][age].Add(person);
    }

    public int Count
    {
        get
        {
            return this.personsByEmail.Count;
        }
    }

    public Person FindPerson(string email)
    {
        if (!this.personsByEmail.ContainsKey(email))
        {
            return null;
        }

        return this.personsByEmail[email];
    }

    public bool DeletePerson(string email)
    {
        if (!this.personsByEmail.ContainsKey(email))
        {
            return false;
        }
        Person person = this.personsByEmail[email];
        this.personsByEmail.Remove(email);
        string domain = email.Split('@')[1];
        this.personsByEmailDomain[domain].Remove(person);
        this.personsByAge[person.Age].Remove(person);
        string nameAndTown = this.CombineNameAndTown(person.Name, person.Town);

        this.personsByNameAndTown[nameAndTown].Remove(person);
        this.personsByTownAndAge[person.Town][person.Age].Remove(person);
        return true;
    }

    public IEnumerable<Person> FindPersons(string emailDomain)
    {
        if (!this.personsByEmailDomain.ContainsKey(emailDomain))
        {
            return new List<Person>();
        }
        return this.personsByEmailDomain[emailDomain];
    }

    public IEnumerable<Person> FindPersons(string name, string town)
    {
        string nameAndTown = this.CombineNameAndTown(name, town);
        return this.personsByNameAndTown.GetValuesForKey(nameAndTown);
    }

    public IEnumerable<Person> FindPersons(int startAge, int endAge)
    {
        var personsInRange = this.personsByAge.Range(startAge, true, endAge, true);
        foreach (var personsByAge in personsInRange)
        {
            foreach (var person in personsByAge.Value)
            {
                yield return person;
            }
        }
    }

    public IEnumerable<Person> FindPersons(
        int startAge, int endAge, string town)
    {
        if (!this.personsByTownAndAge.ContainsKey(town))
        {
            return new List<Person>();
        }

        var personsInRange = this.personsByTownAndAge[town]
            .Range(startAge, true, endAge, true);
        List<Person> result = new List<Person>();
        foreach (var personsByAge in personsInRange)
        {
            foreach (var person in personsByAge.Value)
            {
                result.Add(person);
            }
        }
        return result;
    }
}
