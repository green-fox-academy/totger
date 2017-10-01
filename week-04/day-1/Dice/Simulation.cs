using System;
using System.Diagnostics;
namespace DiceSimulation
{
    public class Simulation
    {
        static Stopwatch stopWatch = new Stopwatch();
        private int times;
        		
        public void StartSimulation(int diceNum, int times)
		{
            var testDice = SetupSimulation(diceNum, times);
			
            for (int method = 2; method <= 4; method++)
			{
				for (int j = 0; j < times; j++)
				{
					RunSimulation(testDice, method);
				}
				PrintResults(method, times);
				stopWatch.Reset();
			}
		}

        public Dice SetupSimulation(int diceNum, int times)
        {
			this.times = times;
            Dice testDice = new Dice(diceNum);

			Console.WriteLine("*** {0} Dice *** {1} Runs ***",
							  testDice.dice.Count, times);
            return testDice;
        }

        public void RunSimulation(Dice testDice, int method)
		{
            testDice.RollAll();
			switch (method)
			{
				case 1:
					stopWatch.Start();
					testDice.RollAllUntilAllSixes();
					stopWatch.Stop();
					break;
				case 2:
                    stopWatch.Start();
                    testDice.OneByOneRecursive(testDice.dice.Count - 1);
					stopWatch.Stop();
					break;
				case 3:
					stopWatch.Start();
					testDice.OneByOne();
					stopWatch.Stop();
					break;
				case 4:
					stopWatch.Start();
					testDice.RerollExceptSixes();
					stopWatch.Stop();
					break;
			}
		}

		public void PrintResults(int method, int times)
		{
			TimeSpan timespan = stopWatch.Elapsed;
			double result = timespan.TotalMilliseconds;
			Console.WriteLine("\n{0}. method\n" +
							  "Average time: {1} ms\n" +
                              "_______________________________",
							  method, result / times);
		}
	}
}
