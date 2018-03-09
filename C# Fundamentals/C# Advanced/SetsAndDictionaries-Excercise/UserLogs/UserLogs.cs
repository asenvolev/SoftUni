using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new SortedDictionary<string, Dictionary<string, int>>();
            while (input[0]!="end")
            {
                var ip = input[1];
                var user = input[5];
                if (dict.ContainsKey(user))
                {
                    if (dict[user].ContainsKey(ip))
                    {
                        dict[user][ip] += 1;
                    }
                    else
                    {
                        dict[user].Add(ip,1);
                    }
                }
                else
                {
                    dict.Add(user, new Dictionary<string, int>());
                    dict[user].Add(ip, 1);
                }
                input = Console.ReadLine().Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var user in dict)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine($"{string.Join(", ",user.Value.Select(a=>$"{a.Key} => {a.Value}"))}.");
            }
        }
    }
}
