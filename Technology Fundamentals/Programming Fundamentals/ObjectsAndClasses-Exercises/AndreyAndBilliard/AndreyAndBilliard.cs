using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class AndreyAndBilliard
    {
        static void Main(string[] args)
        {
            int countProd = int.Parse(Console.ReadLine());
            var Products = new Dictionary<string, decimal>();
            var listOfCustomers = new List<Customer>();
            for (int i = 0; i < countProd; i++)
            {
                var inputProd = Console.ReadLine().Split('-');
                if (!Products.ContainsKey(inputProd[0]))
                {
                    Products.Add(inputProd[0], decimal.Parse(inputProd[1]));
                }
                else
                {
                    Products[inputProd[0]] = decimal.Parse(inputProd[1]);
                }
            }
            var inputCustomer = Console.ReadLine().Split('-');
            while (inputCustomer[0]!="end of clients")
            {
                string currClient = inputCustomer[0];
                string[] currProducts = inputCustomer[1].Split(',');
                Customer currCustomer = new Customer
                {
                    Name = currClient,
                    Product = new Dictionary<string, int>(),

                };
                currCustomer.Product.Add(currProducts[0], int.Parse(currProducts[1]));
                foreach (var item in Products)
                {
                    if (item.Key == currProducts[0])
                    {
                        listOfCustomers.Add(currCustomer);
                    }
                }

                foreach (var cust in listOfCustomers)
                {
                    foreach (var item in cust.Product)
                    {
                        foreach (var itemProd in Products)
                        {
                            if (itemProd.Key == item.Key)
                            {
                                cust.Bill = item.Value * itemProd.Value;
                            }
                        }
                    }
                }
                inputCustomer = Console.ReadLine().Split('-');
            }
            decimal totalBill = 0;
            var sortedList = listOfCustomers
                .OrderBy(a => a.Name);
            foreach (var cust in sortedList)
            {
                Console.WriteLine(cust.Name);
                foreach (var item in cust.Product)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {cust.Bill:f2}");
                totalBill += cust.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");

        }
    }
}
