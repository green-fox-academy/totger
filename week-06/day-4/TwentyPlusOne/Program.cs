using System;

namespace TwentyPlusOne
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.StartGame();
            game.Deal();
        }
    }
}
