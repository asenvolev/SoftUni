using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            int logs = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < logs; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string ip = input[0];
                string user = input[1];
                int duration = int.Parse(input[2]);
                if (!dict.ContainsKey(user))
                {
                    dict.Add(user, new SortedDictionary<string, int>());
                }
                if (!dict[user].ContainsKey(ip))
                {
                    dict[user][ip] = 0;
                }
                dict[user][ip] += duration;
            }
            foreach (var user in dict)
            {
                Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{string.Join(", ", user.Value.Keys)}]");
            }
        }
    }
}
