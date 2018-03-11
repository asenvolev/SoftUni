using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidStudentFilter:Exception
    {
        private const string InvalidStudent ="The given filter is not one of the following: excellent/average/poor";
        public InvalidStudentFilter():base(InvalidStudent)
        {

        }
        public InvalidStudentFilter(string message):base(message)
        {

        }
    }
}
