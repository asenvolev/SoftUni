using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText("words.txt").Split(new[] { ' ',',', '\"', '.', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray();

            var text = File.ReadAllText("Input.txt").Split(new[] { ' ',',', '\"', '.', '!', '?', '-','\n','\r' }, StringSplitOptions.RemoveEmptyEntries).Select(w => w.ToLower()).ToArray();
            var countWords = new Dictionary<string, int>();
            foreach (var word in words)
            {
                for (int i = 0; i < text.Length; i++)
                {

                    if (text[i] == word)
                    {
                        if (!countWords.ContainsKey(word))
                        {
                            countWords.Add(word, 0);
                        }
                        countWords[word]++;
                    }
                }
            }
            var sortedResult = countWords.OrderByDescending(x => x.Value).Select(x => $"{x.Key} - {x.Value}").ToArray();
            File.WriteAllLines("Output.txt", sortedResult);
        }
    }
}
