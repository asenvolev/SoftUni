using System;

namespace RecursiveDrawing
{
    public class RecursiveDrawing
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            Draw(input);
        }

        public static void Draw(int input)
        {
            if (input <=0)
            {
                return;
            }

            Console.WriteLine(new string('*',input));
            Draw(input-1);
            Console.WriteLine(new string('#',input));
        }
    }
}
