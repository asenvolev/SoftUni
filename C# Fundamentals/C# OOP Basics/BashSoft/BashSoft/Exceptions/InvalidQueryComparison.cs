using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidQueryComparison:Exception
    {
        private const string InvalidQuery= "The comparison query you want, does not exist in the context of the current program!";
        public InvalidQueryComparison():base(InvalidQuery)
        {
                
        }
        public InvalidQueryComparison(string message):base(message)
        {

        }
    }
}
