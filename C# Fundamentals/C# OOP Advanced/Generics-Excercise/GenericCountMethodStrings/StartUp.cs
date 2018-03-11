using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodStrings
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var elements = new List<Box<double>>();
            for (int i = 0; i < input; i++)
            {
                var rndString = new Box<double>(double.Parse(Console.ReadLine()));
                elements.Add(rndString);
            }
            var strToCmpr = double.Parse(Console.ReadLine());
            int numToPrint = CountGreaterElements(elements, strToCmpr);
            Console.WriteLine(numToPrint);
        }
        public static int CountGreaterElements<T>(List<Box<T>> elements, T element) where T : IComparable<T>
        {
            int counter = elements.Count(x => x.Value.CompareTo(element) > 0);
            return counter;
        }
    }
}
