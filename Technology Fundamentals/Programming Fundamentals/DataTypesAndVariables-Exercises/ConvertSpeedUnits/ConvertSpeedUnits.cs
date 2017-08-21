using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            float distanceMeter = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float alltheseconds = seconds + minutes * 60 + hours * 3600;
            float meterps = distanceMeter / alltheseconds;
            float kmph = (distanceMeter / 1000) / (alltheseconds / 3600);
            float mph = (float)(kmph / 1.609344);
            Console.WriteLine($"{meterps:f7}\n{kmph:f7}\n{mph:f7}");
        }
    }
}
