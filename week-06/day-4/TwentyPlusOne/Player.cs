using System;
namespace TwentyPlusOne
{
    public class Player : Players
    {
        public int Balance;
        public int Bet;

        public Player()
        {
            Balance = 1000;
        }

        public void PlaceBet(int bet)
        {
            Bet = bet;
            Balance -= Bet;
        }
    }
}
