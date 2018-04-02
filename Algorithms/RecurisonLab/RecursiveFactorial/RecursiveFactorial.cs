using System;

namespace RecursiveFactorial
{
    public class RecursiveFactorial
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var result = Factorial(input);
            Console.WriteLine(result);
        }

        private static int Factorial(int index)
        {
            if (index == 1)
            {
                return 1;
            }

            return index * Factorial(--index);
        }
        
    }
}
