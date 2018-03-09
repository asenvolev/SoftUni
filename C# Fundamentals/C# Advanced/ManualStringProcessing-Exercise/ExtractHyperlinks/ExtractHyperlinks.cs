using System;
using System.Collections.Generic;
using System.Text;

namespace ExtractHyperlinks
{
    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            int indexOfLink = 5;
            int indexOfTag = 0;
            int indexOfQuotes = 0;
            var sb = new StringBuilder();
            var text = new StringBuilder();
            var set = new HashSet<string>();
            while (input !="END")
            {
                text.AppendLine(input);
                
                input = Console.ReadLine();
            }
            string allText = text.ToString();
            while (allText.Contains("<a"))
            {
                if (allText.Contains("<a") && allText.Contains("href=") || allText.Contains("<a") && allText.Contains("href ="))
                {
                    indexOfTag = allText.IndexOf("<a");
                    indexOfLink = allText.IndexOf("=",allText.IndexOf("href",indexOfTag));
                    indexOfQuotes = indexOfLink + 1;
                    for (int i = indexOfQuotes; i < allText.Length; i++)
                    {
                        char currChar = allText[i];
                        if (currChar == '>' || i > indexOfQuotes && currChar == '"')
                        {
                            break;
                        }
                        sb.Append(currChar);
                    }
                    set.Add(sb.ToString());
                    sb.Clear();
                    allText = allText.Remove(indexOfTag, indexOfQuotes - indexOfTag);
                    
                }
            }
            Console.WriteLine(string.Join("\n",set));
        }
    }
}
