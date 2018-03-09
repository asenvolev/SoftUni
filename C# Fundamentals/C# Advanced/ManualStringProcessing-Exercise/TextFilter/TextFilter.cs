using System;

namespace TextFilter
{
    public class TextFilter
    {
        public static void Main()
        {
            var wordsToReplace = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            foreach (var word in wordsToReplace)
            {
                var newtext = text.Replace(word, new string('*',word.Length));
                text = string.Empty;
                text = newtext;
                newtext = string.Empty;
            }
            Console.WriteLine(text);
        }
    }
}
