using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            var pok1 = int.Parse(Console.ReadLine());
            var pok2 = int.Parse(Console.ReadLine());
            var battles = int.Parse(Console.ReadLine());
            var count = 0;
            var flag = 0;
            for (int i = 1; i <= pok1; i++)
            {
                for (int j = 1; j <= pok2; j++)
                {
                    Console.Write("({0} <-> {1}) ",i,j);
                    count++;
                    if (count == battles)
                    {
                        flag++;
                        break;
                    }
                }
                if (flag==1)
                {
                    break;
                }
            }
        }
    }
}
