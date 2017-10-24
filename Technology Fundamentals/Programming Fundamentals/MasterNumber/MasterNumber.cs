using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                if (isPalindrome(i) && sumOfDigits(i) && containsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool containsEvenDigit(int i)
        {
            int rev = 0;
            while (i > 0)
            {
                int r = i % 10;
                if (r%2==0)
                {
                    return true;
                }
                i = i / 10;  //left = Math.floor(left / 10); 
            }
            return false;

        }

        public static bool sumOfDigits(int i)
        {
            int rev = 0;
            while (i > 0)
            {
                int r = i % 10;
                rev = rev + r;
                i = i / 10;  //left = Math.floor(left / 10); 
            }
            if (rev%7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool isPalindrome(int i)
        {
            int n = i;
            int rev = 0;
            while (i > 0)
            {
                int r = i % 10;
                rev = rev * 10 + r;
                i = i / 10;  //left = Math.floor(left / 10); 
            }

            if (n == rev)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
