using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            
            var items = new Dictionary<string, long>
            {
                { "fragments", 0 },
                { "shards", 0 },
                { "motes", 0 }
            }; 
            var trash = new Dictionary<string, long>();
            bool weaponWon = false;
            while (!weaponWon)
            {
                var input = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < input.Length; i += 2)
                {
                    long quantity = long.Parse(input[i]);
                    string item = input[i + 1];
                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        if (items.ContainsKey(item))
                        {
                            items[item] += quantity;
                        }
                        else
                        {
                            items.Add(item, quantity);
                        }
                        if (items[item] >= 250)
                        {
                            string weaponObtained = ReturnWeapon(item);
                            items[item] -= 250;
                            
                            weaponWon = true;
                            Console.WriteLine(weaponObtained + " obtained!");
                            break;
                        }
                    }
                    else
                    {
                        if (trash.ContainsKey(item))
                        {
                            trash[item] += quantity;
                        }
                        else
                        {
                            trash.Add(item, quantity);
                        }
                    }
                }
            }
            foreach (var item in items.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in trash.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        public static string ReturnWeapon(string material)
        {

            if (material.Equals("shards"))
            {
                return "Shadowmourne";
            }
            else if (material.Equals("fragments"))
            {
                return "Valanyr";
            }
            else if (material.Equals("motes"))
            {
                return "Dragonwrath";
            }

            return "";
        }
    }
}
