using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, decimal>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                decimal quantity = decimal.Parse(Console.ReadLine());
                if (result.ContainsKey(resource))
                {
                    result[resource] += quantity;
                }
                else
                {
                    result.Add(resource, quantity);
                }
                resource = Console.ReadLine();

            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
