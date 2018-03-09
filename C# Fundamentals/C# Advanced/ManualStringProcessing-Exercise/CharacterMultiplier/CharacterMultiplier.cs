using System;

namespace CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '},
                StringSplitOptions.RemoveEmptyEntries);
            string first = input[0];
            string second = input[1];
            int sum = 0;
            int length = Math.Min(first.Length, second.Length);
            for (int i = 0; i < length; i++)
            {
                sum += first[i] * second[i];
            }
            if (length == first.Length)
            {
                for (int i = length; i < second.Length; i++)
                {
                    sum += second[i];
                }
            }
            else
            {
                for (int i = length; i < first.Length; i++)
                {
                    sum += first[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
