using System;
using System.Text;

namespace ConcatenateStrings
{
    public class ConcatenateStrings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(Console.ReadLine()).Append(" ");
            }
            Console.WriteLine(sb);
        }
    }
}
