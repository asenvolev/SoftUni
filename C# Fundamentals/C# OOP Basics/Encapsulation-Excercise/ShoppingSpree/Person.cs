using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bagOfProducts = new List<Product>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }

            internal set
            {
                if (value<0)
                {
                    throw new ArgumentException($"Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost <= this.Money)
            {
                this.bagOfProducts.Add(product);
                this.Money -= product.Cost;
            }
            else
            {
                throw new ArgumentException($"{this.Name} can't afford {product.Name}");
            }
        }
        public override string ToString()
        {
            var result = this.bagOfProducts.Any()
                        ? string.Join(", ", this.bagOfProducts.Select(pr => pr.Name).ToList())
                        : "Nothing bought";
            return $"{this.Name} - {result}";
        }
    }
}
