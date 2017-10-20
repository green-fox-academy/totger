using System;
namespace TwentyPlusOne
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Rank
    {
        Two,
        Three,
        Four ,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    public class Card
    {
        public Suit Suit;
        public Rank Rank;

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
        public override string ToString()
        {
            return string.Format($"{Rank} of {Suit}");
        }
		
        public int GetCardValue(Card card)
		{
			if ((int)card.Rank <= 8)
				return (int)card.Rank + 2;
			
			if ((int)card.Rank >= 9 && (int)card.Rank <= 11)
				return 10;
			
			return 11;
		}
    }

}
