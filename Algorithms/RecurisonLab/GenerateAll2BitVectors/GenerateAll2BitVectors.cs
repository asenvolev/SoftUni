using System;

namespace GenerateAll2BitVectors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            int[] array = new int[input];
            Generate(array);
        }

        private static void Generate(int[] array, int index = 0)
        {
            if (index == array.Length)
            {
                Console.WriteLine(String.Join("", array));
                return;
            }
            array[index] = 0;
            Generate(array, index + 1);
            array[index] = 1;
            Generate(array, index + 1);
        }
    }
}
