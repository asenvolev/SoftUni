using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var grad = Console.ReadLine().ToLower();
            var kol = double.Parse(Console.ReadLine());
            var comission = 0.0;
            if (kol < 0) Console.WriteLine("error");
            else if (grad=="sofia")
            {
                if (kol >= 0 && kol <= 500) comission = 0.05;
                else if (kol > 500 && kol <= 1000) comission = 0.07;
                else if (kol > 1000 && kol <= 10000) comission = 0.08;
                else if (kol > 10000) comission = 0.12;
            }
            else if (grad == "varna")
            {
                if (kol >= 0 && kol <= 500) comission = 0.045;
                else if (kol > 500 && kol <= 1000) comission = 0.075;
                else if (kol > 1000 && kol <= 10000) comission = 0.10;
                else if (kol > 10000) comission = 0.13;
            }
            else if (grad == "plovdiv")
            {
                if (kol >= 0 && kol <= 500) comission = 0.055;
                else if (kol > 500 && kol <= 1000) comission = 0.08;
                else if (kol > 1000 && kol <= 10000) comission = 0.12;
                else if (kol > 10000) comission = 0.145;
            }
            else Console.WriteLine("error");
            Console.WriteLine(kol*comission);
        }
    }
}
