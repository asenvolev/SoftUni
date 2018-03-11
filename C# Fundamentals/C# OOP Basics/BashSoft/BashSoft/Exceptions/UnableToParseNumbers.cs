using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class UnableToParseNumbers:Exception
    {
        private const string UnableToParseNumber = "The sequence you've written is not a valid number.";
        public UnableToParseNumbers():base(UnableToParseNumber)
        {

        }
        public UnableToParseNumbers(string message):base(message)
        {

        }
    }
}
