using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split().ToArray();
            Random rand = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                string current = words[i];
                int random = rand.Next(0,words.Length);
                var tempword = words[random];
                words[i] = tempword;
                words[random] = current;
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
