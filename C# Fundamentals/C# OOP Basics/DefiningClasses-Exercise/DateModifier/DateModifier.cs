using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateModifier
{
    public static class DateModifier
    {
        public static double Parse(string first, string second)
        {
            DateTime parsedFirstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime parsedSecondDate = DateTime.ParseExact(second, "yyyy MM dd", CultureInfo.InvariantCulture);
            return Math.Abs((parsedFirstDate - parsedSecondDate).TotalDays);
        }
    }
}
