using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

public class ShoppingCenter
{
    Dictionary<string, List<Product>> byName;
    Dictionary<string, List<Product>> byProducer;
    Dictionary<string, List<Product>> byNameAndProducer;
    OrderedBag<Product> byPrice;

    public ShoppingCenter()
    {
        this.byName = new Dictionary<string, List<Product>>();
        this.byProducer = new Dictionary<string, List<Product>>();
        this.byNameAndProducer = new Dictionary<string, List<Product>>();
        this.byPrice = new OrderedBag<Product>(
            (x, y) => x.Price.CompareTo(y.Price)
            );
    }

    public void AddProduct(string name, double price, string producer)
    {
        Product product = new Product(name, price, producer);
        if (!byName.ContainsKey(name))
        {
            byName[name] = new List<Product>();
        }
        byName[name].Add(product);

        if (!byProducer.ContainsKey(producer))
        {
            byProducer[producer] = new List<Product>();
        }
        byProducer[producer].Add(product);

        string nameAndProducer = $"{name}{producer}";

        if (!byNameAndProducer.ContainsKey(nameAndProducer))
        {
            byNameAndProducer[nameAndProducer] = new List<Product>();
        }
        byNameAndProducer[nameAndProducer].Add(product);

        byPrice.Add(product);
    }

    public int DeleteProducts(string producer)
    {
        if (!this.byProducer.ContainsKey(producer))
        {
            return 0;
        }

        var productsToRemove = byProducer[producer];
        foreach (var item in productsToRemove)
        {
            string nameAndProducer = $"{item.Name}{item.Producer}";
            string name = item.Name;
            byName[name].Remove(item);
            byPrice.Remove(item);
            byNameAndProducer[nameAndProducer].Remove(item);
        }
        byProducer.Remove(producer);

        return productsToRemove.Count();
    }

    public int DeleteProducts(string name, string producer)
    {
        string nameAndProducer = $"{name}{producer}";

        if (!this.byNameAndProducer.ContainsKey(nameAndProducer))
        {
            return 0;
        }

        var productsToRemove = byNameAndProducer[nameAndProducer];
        foreach (var item in productsToRemove)
        {
            byName[name].Remove(item);
            byPrice.Remove(item);
            byProducer[producer].Remove(item);
        }
        byNameAndProducer.Remove(nameAndProducer);

        return productsToRemove.Count();
    }

    public IEnumerable<Product> FindProductsByName(string name)
    {
        if (!this.byName.ContainsKey(name))
        {
            return Enumerable.Empty<Product>();
        }
        return this.byName[name].OrderBy(x => x);
    }

    public IEnumerable<Product> FindProductsByProducer(string producer)
    {
        if (!this.byProducer.ContainsKey(producer))
        {
            return Enumerable.Empty<Product>();
        }
        return this.byProducer[producer].OrderBy(x => x);
    }

    public IEnumerable<Product> FindProductsByPriceRange(double fromPrice, double toPrice)
    {
        return this.byPrice
            .Range(new Product("", fromPrice, ""), true, new Product("", toPrice, ""), true)
            .OrderBy(x => x);
    }
}

