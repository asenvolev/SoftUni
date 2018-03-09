using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    public class RecursiveFibonacci
    {
        private static long[] array;
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            array = new long[50];
            Console.WriteLine(GetFibonaci(n));
        }

        public static long GetFibonaci(long n)
        {

            if (n<=2)
            {
                return 1;
            }
            if (array[n-1]!=0)
            {
                return array[n - 1];
            }
            array[n - 1]= GetFibonaci(n - 1) + GetFibonaci(n - 2);
            return array[n - 1];
        }
    }
}
