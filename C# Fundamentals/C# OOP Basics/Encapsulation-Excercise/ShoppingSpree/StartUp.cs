using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var products = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var listOfPeople = new List<Person>();
            var listOfProducts = new List<Product>();
            try
            {
                foreach (var man in people)
                {
                    var tokens = man.Split('=');
                    string name = tokens[0];
                    decimal money = decimal.Parse(tokens[1]);
                    var person = new Person(name, money);
                    listOfPeople.Add(person);
                }
                foreach (var prod in products)
                {
                    var tokens = prod.Split('=').ToArray();
                    string name = tokens[0];
                    decimal cost = decimal.Parse(tokens[1]);
                    var product = new Product(name, cost);
                    listOfProducts.Add(product);
                }
                var input = Console.ReadLine();
                while (input != "END")
                {
                    var tokens = input.Split(' ').ToArray();
                    string personName = tokens[0];
                    string productName = tokens[1];
                    var currPerson = listOfPeople.FirstOrDefault(x => x.Name == personName);
                    var currProduct = listOfProducts.FirstOrDefault(x => x.Name == productName);
                    try
                    {
                        currPerson.AddProduct(currProduct);
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    input = Console.ReadLine();
                }
                foreach (var person in listOfPeople)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
