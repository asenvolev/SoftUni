using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var primeInRange = primeFinder(startNum, endNum);
            Console.WriteLine(string.Join(", ", primeInRange));
        }

        public static List<int> primeFinder(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (primeChecker(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
        }

        public static bool primeChecker(int currentNum)
        {
            bool prime = true;
            if (currentNum == 0 || currentNum == 1)
            {
                prime = false;
                return prime;
            }
            else
            {
                

                for (int i = 2; i <= Math.Sqrt(currentNum); i++)
                {
                    if (currentNum % i == 0)
                    {
                        prime = false;
                        return prime;
                    }
                }

                return prime;
            }
        }
    }
}
