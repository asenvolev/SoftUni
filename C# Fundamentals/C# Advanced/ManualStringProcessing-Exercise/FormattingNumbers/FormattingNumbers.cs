using System;
using System.Linq;

namespace FormattingNumbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int a = int.Parse(input[0]);
            string b = $"{double.Parse(input[1]):f2}";
            string c = $"{double.Parse(input[2]):f3}";
            string hexa = a.ToString("X").PadRight(10,' ');
            string bina = Convert.ToString(a, 2).PadLeft(10, '0');
            if (bina.Length>10)
            {
                bina = bina.Remove(10);
            }
            Console.WriteLine($"|{hexa}|{bina}|{b.PadLeft(10,' ')}|{c.PadRight(10, ' ')}|");
        }
    }
}
