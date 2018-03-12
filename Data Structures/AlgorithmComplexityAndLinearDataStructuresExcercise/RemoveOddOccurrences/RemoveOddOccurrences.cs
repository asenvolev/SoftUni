using System;
using System.Linq;

namespace RemoveOddOccurrences
{
    public class RemoveOddOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            int[] count = new int[10];

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < input.Count; y++)
                {
                    if (input[y] == x)
                        count[x]++;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i]%2==1)
                {
                    input.RemoveAll(x => x == i);

                }
            }
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
