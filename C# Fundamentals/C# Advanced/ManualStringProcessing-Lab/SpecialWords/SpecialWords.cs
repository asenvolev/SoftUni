using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecialWords
{
    public class SpecialWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var word in words)
            { 
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, 0);
                }
            }
            var line = Console.ReadLine();
            if (line != string.Empty)
            {
                var input = line.Split(new[] { ' ', ',', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < input.Length; i++)
                {
                    if (dict.ContainsKey(input[i]))
                    {
                        dict[input[i]]++;
                    }
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
