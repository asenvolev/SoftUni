using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxOfString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var list = new List<Box<int>>();
            for (int i = 0; i < input; i++)
            {
                var box = new Box<int>(int.Parse(Console.ReadLine()));
                list.Add(box);
            }
            var swapIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var temp = list[swapIndexes[0]];
            list[swapIndexes[0]] = list[swapIndexes[1]];
            list[swapIndexes[1]] = temp;
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
