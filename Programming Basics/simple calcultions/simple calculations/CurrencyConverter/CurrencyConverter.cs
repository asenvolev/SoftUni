using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            string currency = Console.ReadLine();
            var changeto = Console.ReadLine();
            if (currency == "BGN")
            {
                if (changeto == "USD")
                {
                    value /= 1.79549;
                }
                else if(changeto == "EUR")
                {
                    value /= 1.95583;
                }
                else if(changeto == "GBP")
                {
                    value /= 2.53405;
                }
            }
            else if (currency == "USD")
            {
                if (changeto == "BGN")
                {
                    value *= 1.79549;
                }
                else if (changeto == "EUR")
                {
                    value *= 1.79549;
                    value /= 1.95583;
                }
                else if (changeto == "GBP")
                {
                    value *= 1.79549;
                    value /= 2.53405;
                }
            }
            else if (currency == "EUR")
            {
                if (changeto == "USD")
                {
                    value *= 1.95583;
                    value /= 1.79549;
                }
                else if (changeto == "BGN")
                {
                    value *= 1.95583;
                }
                else if (changeto == "GBP")
                {
                    value *= 1.95583;
                    value /= 2.53405;
                }
            }
            else if (currency == "GBP")
            {
                if (changeto == "USD")
                {
                    value *= 2.53405;
                    value /= 1.79549;
                }
                else if (changeto == "EUR")
                {
                    value *= 2.53405;
                    value /= 1.95583;
                }
                else if (changeto == "BGN")
                {
                    value *= 2.53405;
                }
            }
            Console.WriteLine(Math.Round(value,2)+" "+changeto);
        }
    }
}
