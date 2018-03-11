using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPower
{
    [Type("Suit", "Provides suit constants for a Card class.")]
    public enum CardSuits
    {
        Clubs,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
