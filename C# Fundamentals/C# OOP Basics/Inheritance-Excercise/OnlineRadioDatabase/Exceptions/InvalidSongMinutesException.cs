using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongMinutesException:InvalidSongLengthException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}
