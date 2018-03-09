using System;

namespace ParseTags
{
    public class ParseTags
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            int startIndex = input.IndexOf(openTag);
            while (startIndex!=-1)
            {
                int endIndex = input.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;
                }
                string toBeReplaced = input.Substring(startIndex, endIndex - startIndex + closeTag.Length);
                string replaced = toBeReplaced.Replace(openTag, string.Empty).Replace(closeTag, string.Empty).ToUpper();
                input = input.Replace(toBeReplaced, replaced);
                startIndex = input.IndexOf(openTag);
            }
            Console.WriteLine(input);
        }
    }
}
