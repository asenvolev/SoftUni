using System;

namespace StringLength
{
    public class StringLength
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            
            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
