using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            bool special = false;
            for (int i = 1; i <= n; i++)
            {
                special = false;
                int j = i;
                while (j != 0)
                {
                    sum += j % 10;
                    j = j / 10;
                } 
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                sum = 0;
                Console.WriteLine($"{i} -> {special}");

            }
        }
    }
}
