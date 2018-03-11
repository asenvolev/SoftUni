using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardPower
{
    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuits suit;
        public Card(string rank, string suit)
        {
            this.Rank = (CardRank)Enum.Parse(typeof(CardRank), rank);
            this.Suit = (CardSuits)Enum.Parse(typeof(CardSuits), suit);
        }

        public CardRank Rank
        {
            get
            {
                return rank;
            }

            private set
            {
                rank = value;
            }
        }

        public CardSuits Suit
        {
            get
            {
                return suit;
            }

            private set
            {
                suit = value;
            }
        }

        public int CompareTo(Card other)
        {
            return this.Power().CompareTo(other.Power());
        }

        public int Power()
        {
            return (int)this.Rank + (int)this.Suit;
        }
        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Card card = obj as Card;
            return this.Power().Equals(card.Power());
        }
        public override int GetHashCode()
        {
            return (int)this.Rank*(int)this.Suit;
        }
    }
}
