using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                Console.WriteLine("*");
            }
            else if(n==2)
            {
                Console.WriteLine("**");
            }
            else if(n%2==0)
            {
                int mid = 0;
                int leftright = n / 2 - 1;
                for (int i = 0; i < n/2; i++)
                {
                    Console.WriteLine(new string('-',leftright) + new string('*',1) + new string('-',mid) + new string('*', 1) + new string('-', leftright));
                    mid+=2;
                    leftright--;
                }
                mid -= 2;
                leftright += 1;
                for (int i = 0; i < n/2-1; i++)
                {
                    --mid;
                    --mid;
                    ++leftright;
                    Console.WriteLine(new string('-', leftright) + new string('*', 1) + new string('-', mid) + new string('*', 1) + new string('-', leftright));
                    
                }
            }
            else
            {
                int mid = 1;
                int leftright = (n + 1) / 2 - 1;
                Console.WriteLine(new string('-', leftright) + new string('*', 1) + new string('-', leftright));
                for (int i = 0; i < (n + 1) / 2 - 1; i++)
                {
                    Console.WriteLine(new string('-', leftright-1) + new string('*', 1) + new string('-', mid) + new string('*', 1) + new string('-', leftright-1));
                    mid += 2;
                    leftright--;
                }
                mid -= 4;
                leftright += 2;
                for (int i = 0; i < (n + 1) / 2 - 2; i++)
                {
                    Console.WriteLine(new string('-', leftright - 1) + new string('*', 1) + new string('-', mid) + new string('*', 1) + new string('-', leftright - 1));
                    mid -= 2;
                    leftright++;
                }
                leftright--;
                Console.WriteLine(new string('-', leftright) + new string('*', 1) + new string('-', leftright));

            }
        }
    }
}
