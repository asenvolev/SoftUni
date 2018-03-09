using System;

namespace UnicodeCharacters
{
    public class UnicodeCharacters
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                int num = text[i];
                string result = $"00{num.ToString("X")}".ToLower();
                Console.Write($"\\u{result}");
            }
        }
    }
}
