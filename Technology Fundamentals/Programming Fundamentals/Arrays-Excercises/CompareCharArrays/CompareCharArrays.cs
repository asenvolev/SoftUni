using System;
using System.Linq;

namespace CompareCharArrays
{
    internal class CompareCharArrays
    {
        private static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int shorter = Math.Min(first.Length, second.Length);
            for (int i = 0; i < shorter; i++)
            {
                if (first[i] < second[i])
                {
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                    break;
                }
                else if (first[i] > second[i])
                {
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));
                    break;
                }
                else
                {
                    if (i == shorter - 1)
                    {
                        if (first.Length <= second.Length)
                        {
                            Console.WriteLine(string.Join("", first));
                            Console.WriteLine(string.Join("", second));
                        }
                        else
                        {
                            Console.WriteLine(string.Join("", second));
                            Console.WriteLine(string.Join("", first));
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}