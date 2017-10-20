using System;
using System.Linq;
using System.Collections.Generic;
namespace TwentyPlusOne
{
    public class Deck
    {

        public List<Card> Cards = new List<Card>();
        Random random = new Random();

        public Deck()
        {
            for (int i = 0; i < 6; i++)
            {
                CreateDeck();
            }
            ShuffleDeck();
        }

        public void CreateDeck()
        {
            for (int i = 0; i < Enum.GetNames(typeof(Suit)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Rank)).Length; j++)
                {
                    Cards.Add(new Card((Suit)i, (Rank)j));
                }
            }
        }

        public void ShuffleDeck()
        {
            List<Card> shuffledDeck = new List<Card>();
            for (int i = Cards.Count; i > 0; i--)
            {
                int x = random.Next(0, i);
                shuffledDeck.Add(Cards[x]);
                Cards.RemoveAt(x);
            }
            Cards = shuffledDeck;
        }

        public Card PullCard()
        {
            Card topCard =  Cards[0];
            Cards.RemoveAt(0);
            return topCard;
        }

        public int GetCardValue(Card card)
        {
            if ((int)card.Rank <= 10)
                return (int)card.Rank;

            if ((int)card.Rank >= 11 && (int)card.Rank <= 13)
                return 10;

            return 11;
        }
    }
}
