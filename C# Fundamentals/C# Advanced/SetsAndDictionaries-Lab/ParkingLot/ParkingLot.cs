using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingLot
{
    class ParkingLot
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();
            while (input != "END")
            {
                var tokens = Regex.Split(input, ", ");
                if (tokens[0] == "IN")
                {
                    parking.Add(tokens[1]);
                }
                else
                {
                    parking.Remove(tokens[1]);
                }
                input = Console.ReadLine();
            }
            if (parking.Count>0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
