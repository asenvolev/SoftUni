using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {
            var pairs = Console.ReadLine()
                .Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string pattern = @"([A-Za-z]+)\+*=(\+*.+)";
            var regex = new Regex(pattern);
            while (pairs[0]!="END")
            {
                var dict = new Dictionary<string, List<string>>();
                foreach (var pair in pairs)
                {
                    string keyValue = Regex.Split(pair, @".+?(?=\?)(\?)+").Last();
                    var splited = keyValue.Split('=');
                    string[] keys = splited[0].Trim()
                        .Split(new string[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries); 
                    string[] values = splited[1].Trim()
                        .Split(new string[] { "%20", "+" }, StringSplitOptions.RemoveEmptyEntries);
                    StringBuilder sb = new StringBuilder();
                    foreach (string val in values)
                    {
                        sb.Append(val).Append(" ");
                    }
                    string value = sb.ToString().Trim();
                    sb.Clear();
                    foreach (string k in keys)
                    {
                        sb.Append(k).Append(" ");
                    }
                    string key = sb.ToString().Trim();
                    if (!dict.ContainsKey(key))
                    {
                        dict[key] = new List<string>();
                        dict[key].Add(value);
                    }
                    else
                    {
                        dict[key].Add(value);
                    }
                }
                foreach (var item in dict)
                {
                    Console.Write($"{item.Key}=[{string.Join(", ",item.Value)}]");
                }
                Console.WriteLine();
                pairs = Console.ReadLine().Split(new[] { '&' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            }
        }
    }
}
