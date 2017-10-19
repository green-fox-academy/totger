using System;
namespace TwentyPlusOne
{
    public enum Suit
    {
        clubs,
        diamonds,
        hearts,
        spades
    }

    public enum Rank
    {
        two,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }
    public class Card
    {
        Suit suit;
        Rank rank;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

    }
}
