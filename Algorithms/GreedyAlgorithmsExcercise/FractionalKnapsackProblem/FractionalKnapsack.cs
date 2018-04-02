using System;
using System.Collections.Generic;
using System.Linq;

namespace FractionalKnapsackProblem
{
    public class FractionalKnapsack
    {
        public static void Main()
        {
            var weightCapacity = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).ToArray().First();
            var itemsCount = Console.ReadLine().Split(' ').Skip(1).Select(int.Parse).ToArray().First();

            var items = new List<Item>();

            for (int i = 0; i < itemsCount; i++)
            {
                var itemInfo = Console.ReadLine().Split(' ');
                var price = double.Parse(itemInfo[0]);
                var weight = double.Parse(itemInfo[2]);

                items.Add(new Item(price, weight));
            }

            double currentWeight = 0;
            double currentPrice = 0;

            foreach (var item in items.OrderByDescending(x => x.Price / x.Weight).ToList())
            {
                double weight = item.Weight;
                double price = item.Price;

                if (currentWeight + weight <= weightCapacity)
                {
                    currentWeight += weight;
                    currentPrice += price;
                    Console.WriteLine($"Take 100% of item with price {price:F2} and weight {weight:F2}");
                    if (currentWeight == weightCapacity)
                    {
                        break;
                    }
                }
                else
                {
                    var weightLeft = weightCapacity - currentWeight;
                    currentWeight += weightLeft;
                    var weightPercentsToAdd = (weightLeft / weight) * 100;

                    var priceToAdd = (price * weightPercentsToAdd) / 100;
                    currentPrice += priceToAdd;

                    Console.WriteLine($"Take {weightPercentsToAdd:F2}% of item with price {price:F2} and weight {weight:F2}");
                    break;
                }
            }
            Console.WriteLine($"Total price: {currentPrice:F2}");
        }

    }

    class Item
    {
        public Item(double price, double weight)
        {
            this.Price = price;
            this.Weight = weight;
        }
        public double Price { get; set; }

        public double Weight { get; set; }
    }
}
