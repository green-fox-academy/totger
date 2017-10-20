using System;
using System.Collections.Generic;
namespace TwentyPlusOne
{
    public class Players
    {
        public int Score;
        public List<Card> Hand;

        public Players()
        {
            Hand = new List<Card>();
        }
    }
}
