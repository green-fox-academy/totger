using System.Collections.Generic;
namespace TwentyPlusOne
{
    public class Deck
    {

        List<Card> deck = new List<Card>();

        public Deck()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck.Add(new Card((Suit)i, (Rank)j));
                }
            }
        }
    }
}
