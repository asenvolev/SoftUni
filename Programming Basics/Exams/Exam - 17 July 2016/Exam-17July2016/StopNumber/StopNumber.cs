using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopNumber
{
    class StopNumber
    {
        static void Main(string[] args)
        {
            var bot = int.Parse(Console.ReadLine());
            var top = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());
            for (int i = top; i >= bot; i--)
            {
                if(i%2==0 && i%3==0)
                {
                    if (i==stop)
                    {
                        break;
                    }
                    Console.Write(i+" ");
                }
            }


        }
    }
}
