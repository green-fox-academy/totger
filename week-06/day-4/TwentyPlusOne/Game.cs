using System;
namespace TwentyPlusOne
{
    public class Game
    {
        Players player;
        Players dealer;
        Deck deck;

        public void StartGame()
        {
            player = new Player();
            dealer = new Dealer();
            deck = new Deck();
        }
        public void Deal()
        {
            player.Hand.Add(deck.PullCard());
            dealer.Hand.Add(deck.PullCard());
            player.Hand.Add(deck.PullCard());

            PrintStatistics();
        }

        private void PrintStatistics()
        {
            PrintPlayersHand();
            PrintPlayersScore();
            PrintDealersHand();
            PrintDealersScore();
        }

        private void PrintDealersScore()
        {
            GetDealersScore();
            Console.WriteLine($"Dealer's score: \n{dealer.Score}\n");
        }

        private void GetDealersScore()
        {
            foreach (var card in dealer.Hand)
            {
                dealer.Score += card.GetCardValue(card);
                if (dealer.Hand.Exists(x => x.Rank == Rank.Ace)
                    && dealer.Score > 21)
                {
                    dealer.Score -= 10;
                }
            }
        }

        private void PrintPlayersScore()
        {
            GetPlayersScore();
            Console.WriteLine($"Player's score: \n{player.Score}\n");
        }

        private void GetPlayersScore()
        {
            foreach (var card in player.Hand)
            {
                player.Score += card.GetCardValue(card);
                if (player.Hand.Exists(x => x.Rank == Rank.Ace)
                    && player.Score > 21)
                {
                    player.Score -= 10;
                }
            }
        }

        private void PrintDealersHand()
        {
            Console.WriteLine($"Dealer's hand: ");
            foreach (var card in dealer.Hand)
            {
                Console.Write($" | {card} | ");
            }
            Console.WriteLine();
        }

        private void PrintPlayersHand()
        {
            Console.WriteLine($"Player's hand: ");
            foreach (var card in player.Hand)
            {
                Console.Write($" | {card} | ");
            }
            Console.WriteLine();
        }
    }
}
