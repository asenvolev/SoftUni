using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var numberOfInputs = int.Parse(Console.ReadLine());
        ShoppingCenter center = new ShoppingCenter();
        var sb = new StringBuilder();
        for (int i = 0; i < numberOfInputs; i++)
        {
            var input = Console.ReadLine();
            int indexOfFirstSpace = input.IndexOf(' ');

            var args = input.Substring(indexOfFirstSpace+1).Split(';');


            string command = input.Substring(0,indexOfFirstSpace);

            switch (command)
            {
                case "AddProduct":
                    center.AddProduct(args[0], double.Parse(args[1]), args[2]);
                    sb.AppendLine("Product added");
                    break;
                case "DeleteProducts":
                    int deletedProducts = 0;
                    if (args.Length==1)
                    {
                        deletedProducts = center.DeleteProducts(args[0]);
                    }
                    else
                    {
                        deletedProducts = center.DeleteProducts(args[0], args[1]);
                    }
                    if (deletedProducts == 0)
                    {
                        sb.AppendLine("No products found");
                        break;
                    }
                    sb.AppendLine($"{deletedProducts} products deleted");
                    break;
                case "FindProductsByName":
                    var productsByName = center.FindProductsByName(args[0]);
                    AppendResults(productsByName, sb);
                    break;
                case "FindProductsByProducer":
                    var productsByProducer = center.FindProductsByProducer(args[0]);
                    AppendResults(productsByProducer, sb);

                    break;
                case "FindProductsByPriceRange":
                    var productsByPriceRange = center.FindProductsByPriceRange(double.Parse(args[0]), double.Parse(args[1]));
                    AppendResults(productsByPriceRange, sb);

                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(sb.ToString().Trim());
    }

    private static void AppendResults(IEnumerable<Product> productsByName, StringBuilder sb)
    {
        if (productsByName.Count() == 0)
        {
            sb.AppendLine($"No products found");
            return;
        }
        foreach (var item in productsByName)
        {
            sb.AppendLine($"{{{item.Name};{item.Producer};{item.Price.ToString("F2")}}}");
        }
    }
}

