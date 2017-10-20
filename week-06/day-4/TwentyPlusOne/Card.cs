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
        two = 2,
        three,
        four ,
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
        public Suit Suit;
        public Rank Rank;

        public Card(Suit suit, Rank rank)
        {
            this.Suit = suit;
            this.Rank = rank;
        }
        public override string ToString()
        {
            return string.Format($"{Suit} {Rank}");
        }
    }
}
