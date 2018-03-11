using System;

namespace BashSoft.Exceptions
{
    public class InvalidCommandException : Exception
    {
        public const string exception = "The command {0} is invalid!";

        public InvalidCommandException(string input)
            : base(string.Format(exception, input))
        {
        }
    }
}