using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var inputBomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Add(0);
            input.Add(0);
            input.Add(0);
            foreach (var item in input.ToList())
            {
                if (input.Contains(inputBomb[0]))
                {
                    int start = 0;
                    int bombRadius = inputBomb[1];
                    int where = input.IndexOf(inputBomb[0]);
                    if (where-bombRadius >0)
                    {
                        start = where - bombRadius;
                    }
                    int end = 0;
                    if (where+bombRadius< input.Count - 1)
                    {
                        end = where + bombRadius;
                    }
                    for (int i = start; i <=end; i++)
                    {
                        input.RemoveAt(start);
                    }
                }
                if (!input.Contains(inputBomb[0]))
                {
                    break;
                }
            }
            int result = input.Sum();
            Console.WriteLine(result);
        }
    }
}
