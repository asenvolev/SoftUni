using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase.Exceptions
{
    public class InvalidArtistNameException:InvalidSongException
    {
        public override string Message => "Artist name should be between 3 and 20 symbols.";
    }
}
