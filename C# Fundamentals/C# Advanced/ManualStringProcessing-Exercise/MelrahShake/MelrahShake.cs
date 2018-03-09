using System;

namespace MelrahShake
{
    public class MelrahShake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = Console.ReadLine();
            while (true)
            {
                int first = text.IndexOf(pattern);
                int last = text.LastIndexOf(pattern);
                if (first== -1 || first == last)
                {
                    break;
                }
                
                text = text.Remove(last, pattern.Length);
                text = text.Remove(first, pattern.Length);
                Console.WriteLine("Shaked it.");
                if (pattern.Length > 1)
                {
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
