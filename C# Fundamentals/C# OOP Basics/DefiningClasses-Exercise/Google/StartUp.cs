using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var persons = new List<Person>();
            while (input!="End")
            {
                var tokens = input.Split(' ').ToArray();
                string name = tokens[0];
                if (persons.Any(x => x.Name == name))
                {
                    var thisPerson = persons.Where(x => x.Name == name).FirstOrDefault();
                    switch (tokens[1])
                    {
                        default:
                            break;
                        case "company":
                            string companyName = tokens[2];
                            string department = tokens[3];
                            decimal salary = decimal.Parse(tokens[4]);
                            var company = new Company(companyName, department, salary);
                            thisPerson.Company = company;
                            break;
                        case "car":
                            string model = tokens[2];
                            int speed = int.Parse(tokens[3]);
                            var car = new Car(model, speed);
                            thisPerson.Car = car;
                            break;
                        case "pokemon":
                            string pokemonName = tokens[2];
                            string type = tokens[3];
                            var pokemon = new Pokemon(pokemonName, type);
                            if (thisPerson.Pokemons!=null)
                            {
                                thisPerson.Pokemons.Add(pokemon);
                            }
                            else
                            {
                                thisPerson.Pokemons = new List<Pokemon>();
                                thisPerson.Pokemons.Add(pokemon);
                            }
                            break;
                        case "children":
                            string childName = tokens[2];
                            string childBirthday = tokens[3];
                            var child = new Child(childName, childBirthday);
                            if (thisPerson.Children != null)
                            {
                                thisPerson.Children.Add(child);
                            }
                            else
                            {
                                thisPerson.Children = new List<Child>();
                                thisPerson.Children.Add(child);
                            }
                            break;
                        case "parents":
                            string parentName = tokens[2];
                            string parentBirthday = tokens[3];
                            var parent = new Parent(parentName, parentBirthday);
                            if (thisPerson.Parents!=null)
                            {
                                thisPerson.Parents.Add(parent);
                            }
                            else
                            {
                                thisPerson.Parents = new List<Parent>();
                                thisPerson.Parents.Add(parent);
                            }
                            break;
                    }
                }
                else
                {
                    var person = new Person();
                    switch (tokens[1])
                    {
                        default:
                            break;
                        case "company":
                            string companyName = tokens[2];
                            string department = tokens[3];
                            decimal salary = decimal.Parse(tokens[4]);
                            var company = new Company(companyName, department, salary);
                            person = new Person(name, company);
                            persons.Add(person);
                            break;
                        case "car":
                            string model = tokens[2];
                            int speed = int.Parse(tokens[3]);
                            var car = new Car(model, speed);
                            person = new Person(name, car);
                            persons.Add(person);
                            break;
                        case "pokemon":
                            string pokemonName = tokens[2];
                            string type = tokens[3];
                            var pokemon = new Pokemon(pokemonName, type);
                            person = new Person(name, new List<Pokemon>() { pokemon });
                            persons.Add(person);
                            break;
                        case "children":
                            string childName = tokens[2];
                            string childBirthday = tokens[3];
                            var child = new Child(childName, childBirthday);
                            person = new Person(name, new List<Child>() { child });
                            persons.Add(person);
                            break;
                        case "parents":
                            string parentName = tokens[2];
                            string parentBirthday = tokens[3];
                            var parent = new Parent(parentName, parentBirthday);
                            person = new Person(name, new List<Parent>() { parent });
                            persons.Add(person);
                            break;
                    }
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            var personToPrint = persons.Where(x => x.Name == input).FirstOrDefault();
            Console.WriteLine($"{personToPrint.Name}\nCompany:");
            if (personToPrint.Company!=null)
            {
                Console.WriteLine($"{personToPrint.Company.Name} {personToPrint.Company.Department} {personToPrint.Company.Salary:f2}");
            }
            Console.WriteLine("Car:");
            if (personToPrint.Car!=null)
            {
                Console.WriteLine($"{personToPrint.Car.Model} {personToPrint.Car.Speed}");
            }
            Console.WriteLine("Pokemon:");
            if (personToPrint.Pokemons!=null)
            {
                foreach (var pokemon in personToPrint.Pokemons)
                {
                    Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
                }
            }
            Console.WriteLine("Parents:");
            if (personToPrint.Parents!=null)
            {
                foreach (var parent in personToPrint.Parents)
                {
                    Console.WriteLine($"{parent.Name} {parent.Birthday}");
                }
            }
            Console.WriteLine("Children:");
            if (personToPrint.Children!=null)
            {
                foreach (var child in personToPrint.Children)
                {
                    Console.WriteLine($"{child.Name} {child.Birthday}");
                }
            }
        }
    }
}
