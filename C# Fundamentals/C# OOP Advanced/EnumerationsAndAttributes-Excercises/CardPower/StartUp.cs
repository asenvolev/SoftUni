using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CardPower
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstPlayerCards = new List<Card>();
            var secondPlayerCards = new List<Card>();
            var firstPlayerName = Console.ReadLine();
            var secondPlayerName = Console.ReadLine();
            Card biggestCard = new Card("Two", "Clubs");
            while (secondPlayerCards.Count<5)
            {
                var input = Console.ReadLine().Split();
                try
                {
                    Card currCard = new Card(input[0], input[2]);
                    if (firstPlayerCards.Contains(currCard) || secondPlayerCards.Contains(currCard))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        if (biggestCard.CompareTo(currCard)<0)
                        {
                            biggestCard = currCard;
                        }
                        if (firstPlayerCards.Count < 5)
                        {
                            firstPlayerCards.Add(currCard);
                        }
                        else
                        {
                            secondPlayerCards.Add(currCard);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
            }
            if (firstPlayerCards.Contains(biggestCard))
            {
                Console.WriteLine($"{firstPlayerName} wins with {biggestCard}.");
            }
            else
            {
                Console.WriteLine($"{firstPlayerName} wins with {biggestCard}.");
            }
        }

        public static void CheckCard(Card currCard)
        {
            throw new NotImplementedException();
        }

        public static void PrintAttribute(Type type)
        {
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }

        public static Card ReadCard()
        {
            var cardRank = Console.ReadLine();
            var cardSuit = Console.ReadLine();
            var card = new Card(cardRank, cardSuit);
            return card;
        }
    }
}
