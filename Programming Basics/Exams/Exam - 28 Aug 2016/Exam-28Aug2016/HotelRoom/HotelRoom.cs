using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = double.Parse(Console.ReadLine());
            var studiodiscount = 0.0;
            var apartmentdiscount = 0.0;
            var studio = 0.0;
            var apartment = 0.0;
            if (month == "may" || month == "october")
            {
                studio = 50;
                apartment = 65;
                if (nights > 7 &&nights<=14 )
                {
                    studiodiscount = 0.95;
                    studio *= studiodiscount;
                }
                else if (nights > 14)
                {
                    studiodiscount = 0.7;
                    studio *= studiodiscount;
                    apartmentdiscount = 0.9;
                    apartment *= apartmentdiscount;
                }
            }
            if (month == "june" || month == "september")
            {
                studio = 75.20;
                apartment = 68.70;
                
                if (nights > 14)
                {
                    apartmentdiscount = 0.9;
                    apartment *= apartmentdiscount;
                    studiodiscount = 0.8;
                    studio *= studiodiscount;
                }
            }
            if (month == "july" || month == "august")
            {
                studio = 76;
                apartment = 77;
                
                if (nights > 14)
                {
                    apartmentdiscount = 0.9;
                    apartment *= apartmentdiscount;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.",apartment*nights);
            Console.WriteLine("Studio: {0:f2} lv.", studio*nights);

        }
    }
}
