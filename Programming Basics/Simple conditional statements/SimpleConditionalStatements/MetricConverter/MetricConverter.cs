using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            string fromvalue = Console.ReadLine();
            string tovalue = Console.ReadLine();
            double result = 0;
            if (fromvalue=="mm")
            {
                if (tovalue=="mm")
                {
                    result = num;
                }
                if (tovalue == "cm")
                {
                    result = num/10;
                }
                if (tovalue == "m")
                {
                    result = num/1000;
                }
                if (tovalue == "km")
                {
                    result = num/1000000;
                }
                if (tovalue == "in")
                {
                    result = num* 0.0393700787;
                }
                if (tovalue == "ft")
                {
                    result = num/304.8;
                }
                if (tovalue == "yd")
                {
                    result = num* 0.0010936133;
                }
                if (tovalue == "mi")
                {
                    result = num* 6.21371192*Math.Pow(10,-7);
                }
            }
            if (fromvalue == "cm")
            {
                if (tovalue == "mm")
                {
                    result = num*10;
                }
                if (tovalue == "cm")
                {
                    result = num;
                }
                if (tovalue == "m")
                {
                    result = num/100;
                }
                if (tovalue == "km")
                {
                    result = num/100000;
                }
                if (tovalue == "in")
                {
                    result = num* 0.393700787;
                }
                if (tovalue == "ft")
                {
                    result = num/ 30.48;
                }
                if (tovalue == "yd")
                {
                    result = num* 0.010936133;
                }
                if (tovalue == "mi")
                {
                    result = num * 6.21371192 * Math.Pow(10, -6);
                }
            }
            if (fromvalue == "m")
            {
                if (tovalue == "mm")
                {
                    result = num*1000;
                }
                if (tovalue == "cm")
                {
                    result = num*100;
                }
                if (tovalue == "m")
                {
                    result = num;
                }
                if (tovalue == "km")
                {
                    result = num/1000;
                }
                if (tovalue == "in")
                {
                    result = num* 39.3700787;
                }
                if (tovalue == "ft")
                {
                    result = num* 3.28084;
                }
                if (tovalue == "yd")
                {
                    result = num* 1.0936;
                }
                if (tovalue == "mi")
                {
                    result = num* 0.000621371192;
                }
            }
            if (fromvalue == "km")
            {
                if (tovalue == "mm")
                {
                    result = num*1000000;
                }
                if (tovalue == "cm")
                {
                    result = num*100000;
                }
                if (tovalue == "m")
                {
                    result = num*1000;
                }
                if (tovalue == "km")
                {
                    result = num;
                }
                if (tovalue == "in")
                {
                    result = num* 39370.0787;
                }
                if (tovalue == "ft")
                {
                    result = num* 3280.8399;
                }
                if (tovalue == "yd")
                {
                    result = num* 1093.6133;
                }
                if (tovalue == "mi")
                {
                    result = num* 0.621371192;
                }
            }
            if (fromvalue == "in")
            {
                if (tovalue == "mm")
                {
                    result = num* 25.4;
                }
                if (tovalue == "cm")
                {
                    result = num* 2.54;
                }
                if (tovalue == "m")
                {
                    result = num* 0.0254;
                }
                if (tovalue == "km")
                {
                    result = num * 0.0000254;
                }
                if (tovalue == "in")
                {
                    result = num;
                }
                if (tovalue == "ft")
                {
                    result = num* 0.0833333333;
                }
                if (tovalue == "yd")
                {
                    result = num* 0.0277777778;
                }
                if (tovalue == "mi")
                {
                    result = num* 1.57828283*Math.Pow(10,-5);
                }
            }
            if (fromvalue == "ft")
            {
                if (tovalue == "mm")
                {
                    result = num* 304.8;
                }
                if (tovalue == "cm")
                {
                    result = num* 30.48;
                }
                if (tovalue == "m")
                {
                    result = num/ 3.2808399;
                }
                if (tovalue == "km")
                {
                    result = ((num / 0.0032808399)+0.00001) /Math.Pow(10,6);
                }
                if (tovalue == "in")
                {
                    result = num*12;
                }
                if (tovalue == "ft")
                {
                    result = num;
                }
                if (tovalue == "yd")
                {
                    result = num* 0.333333333;
                }
                if (tovalue == "mi")
                {
                    result = num* 0.000189393939;
                }
            }
            if (fromvalue == "yd")
            {
                if (tovalue == "mm")
                {
                    result = num* 914.4;
                }
                if (tovalue == "cm")
                {
                    result = num* 91.44;
                }
                if (tovalue == "m")
                {
                    result = num* 0.9144;
                }
                if (tovalue == "km")
                {
                    result = num * 0.0009144;
                }
                if (tovalue == "in")
                {
                    result = num* 36;
                }
                if (tovalue == "ft")
                {
                    result = num*3;
                }
                if (tovalue == "yd")
                {
                    result = num;
                }
                if (tovalue == "mi")
                {
                    result = num* 0.000568181818;
                }
            }
            if (fromvalue == "mi")
            {
                if (tovalue == "mm")
                {
                    result = num* 1609344;
                }
                if (tovalue == "cm")
                {
                    result = num* 160934.4;
                }
                if (tovalue == "m")
                {
                    result = num* 1609.344;
                }
                if (tovalue == "km")
                {
                    result = num* 1.609344;
                }
                if (tovalue == "in")
                {
                    result = num*63360;
                }
                if (tovalue == "ft")
                {
                    result = num* 5280;
                }
                if (tovalue == "yd")
                {
                    result = num* 1760;
                }
                if (tovalue == "mi")
                {
                    result = num;
                }
            }
            Console.WriteLine(result);
        }
    }
}
