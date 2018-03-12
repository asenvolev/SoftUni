using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceN_M
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse).ToArray();

            var queue = new Queue<Item>();

            int startVal = input[0];
            int endVal = input[1];

            var firstItem = new Item(startVal, null);
            queue.Enqueue(firstItem);

            while (queue.Count!=0)
            {
                var currItem = queue.Dequeue();
                if (currItem.Value < endVal)
                {
                    queue.Enqueue(new Item(currItem.Value + 1, currItem));
                    queue.Enqueue(new Item(currItem.Value + 2, currItem));
                    queue.Enqueue(new Item(currItem.Value * 2, currItem));
                }
                else if (currItem.Value == endVal)
                {
                    PrintSolution(currItem);
                    break;
                }
            }
        }

        public static void PrintSolution(Item currItem)
        {
            var list = new List<int>();
            while (currItem!= null)
            {
                list.Add(currItem.Value);
                currItem = currItem.PrevItem;
            }
            list.Reverse();
            Console.WriteLine(string.Join(" -> ", list));
        }

        public class Item
        {
            public Item(int value, Item prevItem)
            {
                this.Value = value;
                this.PrevItem = prevItem;
            }
            public int Value { get; set; }
            public Item PrevItem { get; set; }
        }
    }
}
