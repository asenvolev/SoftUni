using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidSongLengthException:InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}
