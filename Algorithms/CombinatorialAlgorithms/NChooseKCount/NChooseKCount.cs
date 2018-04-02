using System;

namespace NChooseKCount
{
    public class NChooseKCount
    {
        public static void Main()
        {
            int allNums = int.Parse(Console.ReadLine());
            int combLenght = int.Parse(Console.ReadLine());
            Console.WriteLine(Binom(allNums,combLenght));
        }

        public static decimal Binom(int n, int k)
        {
            if (k > n)
                return 0;
            if (k == 0 || k == n)
                return 1;
            return Binom(n - 1, k - 1) + Binom(n - 1, k);
        }
    }
}
