using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var letterCounter = new SortedDictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            if (!letterCounter.ContainsKey(input[i]))
            {
                letterCounter.Add(input[i], 0);
            }
            letterCounter[input[i]]++;
        }

        foreach (var pair in letterCounter)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
        }
    }
}

