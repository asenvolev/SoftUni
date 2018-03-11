using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongException : Exception
    {
        private string exceptionMessage;

        public string ExceptionMessage
        {
            set
            {
                this.exceptionMessage = value;
            }
        }
        public override string Message => exceptionMessage;
    }
}
