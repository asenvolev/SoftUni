using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var usernames = Console.ReadLine()
                .Split(new[] { ' ', '\\', '/', '(', ')' },
                StringSplitOptions.RemoveEmptyEntries)
                .Where(u=>Regex.IsMatch(u,@"\b([A-Za-z])([\w+]{2,24})\b"))
                .ToArray();
            int bestSum = 0;
            string bestLengthWord1 = string.Empty;
            string bestLengthWord2 = string.Empty;
            for (int i = 0; i < usernames.Length-1; i++)
            {
                string firstUser = usernames[i];
                string secondUser = usernames[i + 1];
                int sum = firstUser.Length + secondUser.Length;
                if (bestSum<sum)
                {
                    bestSum = sum;
                    bestLengthWord1 = firstUser;
                    bestLengthWord2 = secondUser;
                }
            }
            Console.WriteLine(bestLengthWord1+"\n"+bestLengthWord2);
            
        }
    }
}
