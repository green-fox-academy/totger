using System;

namespace guessthenumber
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("--*** Welcome to Guess The Number ***-- ");

            bool newGame = false;

            do
            {
				bool won = false;
				
				int counter = 0;
				int level;
				int storedNumber = 0;

				while (storedNumber == 0)
				{
					level = ChooseDifficutly();
					storedNumber = GetNumber(level);
				}

				while (!won)
				{
					int guess = GetUserGuess();
					won = Evaluate(guess, storedNumber);
					counter++;
				}
				Console.WriteLine("Congratulations, You won in {0} tries!", counter);
                newGame = RestartGame(newGame);
            } while (newGame);


        }

        private static bool RestartGame(bool newGame)
        {
            Console.Write("Do you want to play again? \n(Yes) - (No) \nType here:");
			string answer = Console.ReadLine();
			answer = answer.ToUpper();
			if (answer == "YES")
				return true;
			return false;				
        }

        private static bool Evaluate(int guess, int number)
        {
            if (guess > number)
            {
                Console.WriteLine("My number is lower");
                return false;
            }
            if (guess < number)
            {
				Console.WriteLine("My number is greater");
                return false;
            }
            return true;
                
        }

        private static int GetUserGuess()
        {
            Console.WriteLine("What's your guess?");
            int guess = Convert.ToInt32(Console.ReadLine());
            return guess;
        }
        private static int GetNumber(int level)
		{
			int number;
			Random random = new Random();
            switch (level)
            {
                case 1:
                    return number = random.Next(1, 101);

                case 2:
                    return number = random.Next(1, 501);

                case 3:
                    return number = random.Next(1, 1001);

                default:
                    return number = 0;
            }
		}

        private static int ChooseDifficutly()
        {
            Console.WriteLine("Please choose difficutly:");
            Console.WriteLine("1 - Easy: 1 - 100 \n2 - Medium: 1 - 500" +
                          "\n3 - Hard: 1 - 1000");
            int level = Convert.ToInt32(Console.ReadLine());
            return level;


        


        }
    }
}