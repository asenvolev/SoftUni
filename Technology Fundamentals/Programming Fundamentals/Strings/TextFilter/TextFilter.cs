using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var banWord = Console.ReadLine().Split(new [] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries );
            var text = Console.ReadLine();
            for (int i = 0; i < banWord.Length; i++)
            {
                text = text.Replace(banWord[i], new string('*', banWord[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
