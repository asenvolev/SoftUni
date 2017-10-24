using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {

            ulong num = ulong.Parse(Console.ReadLine());
            bool prime = true;
            
            if (num == 0 || num ==1)
            {
                prime = false;
                Console.WriteLine(prime);
            }
            else
            {
                double roundNum = Math.Floor(Math.Sqrt(num));

                for (ulong i = 2; i <= roundNum; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }


                Console.WriteLine(prime);
            }
            
        }
    }
}
