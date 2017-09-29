using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Dice
{
	public class Dice
	{
		//    You have a Dice class which has 6 dice
		//    You can roll all of them with Roll()
		//    Check the current rolled numbers with GetCurrent()
		//    You can reroll with Reroll()
		//    Your task is to get where all dice is a 6
        static Random RandomValue;
        static Stopwatch stopWatch = new Stopwatch();
		static int[] Dices = new int[6];

        public int[] Roll()
		{
			for (int i = 0; i < Dices.Length; i++)
			{
				Dices[i] = RandomValue.Next(1, 7);
			}
			return Dices;
		}

		public int[] GetCurrent()
		{
			return Dices;
		}

		public int GetCurrent(int i)
		{
			return Dices[i];
		}

		public void Reroll()
		{
			for (int i = 0; i < Dices.Length; i++)
			{
				Dices[i] = RandomValue.Next(1, 7);
			}
		}

		public void Reroll(int k)
		{
			Dices[k] = new Random().Next(1, 7);
        }

		public void OneByOne(int n)
        {
            while (Dices[n] != 6)
            {
                Reroll(n);
            }
			if (n != 0)
			    OneByOne(n - 1);
        }
		
        public void OneByOne()
		{
			for (int i = 0; i < Dices.Length; i++)
			{
				while (Dices[i] != 6)
				{
					Reroll(i);
				}
			}
		}

		public void RollUntilAllSixes()
        {
            int[] ideal = CreateIdeal();
            while (!Dices.SequenceEqual(ideal))
            {
                Reroll();
            }
        }

		public int[] CreateIdeal()
		{
			List<int> ideal = new List<int>();
			for (int i = 0; i < Dices.Length; i++)
			{
				ideal.Add(6);
			}
			return ideal.ToArray();
		}

        public void RerollExceptSixes()
        {
            while (true)
            {
                List<int> reRoll = CreateRerollList();

                if (reRoll.Count == 0) 
                    break;

                foreach (int index in reRoll)
                {
                    Reroll(index);
                }
            }
        }
		
        public List<int> CreateRerollList()
		{
			List<int> toReroll = new List<int>();
			for (int i = 0; i < Dices.Length; i++)
			{
				if (Dices[i] != 6)
				{
					toReroll.Add(i);
				}
			}
			return toReroll;
		}

        public Dice SetupSimulation(int dices)
        {
			Array.Resize<int>(ref Dices, dices);
			Dice testDice = new Dice();
            return testDice;
        }

        public void RunSimulation(Dice testDice, int method)
        {
            testDice.Roll();
            switch (method)
            {
                case 1:
					stopWatch.Start();
					testDice.RollUntilAllSixes();
					stopWatch.Stop();  
                    break;
                case 2:
					stopWatch.Start();
                    testDice.OneByOne(Dices.Length - 1);
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
                              "Average time: {1} milliseconds", 
                              method, result / times);
        }

        public void StartSimulation(int dices, int times)
        {
            Dice testDice = SetupSimulation(dices);
            Console.WriteLine("----Dices: {0} - Number of tries: {1}----",
                              Dices.Length, times);
            for (int method = 1; method <= 4; method++)
            {
                for (int j = 0; j < times; j++)
                {
                    RunSimulation(testDice, method);
                }
                PrintResults(method, times);
                stopWatch.Reset();
            }
        }

		public static void Main(string[] args)
		{
			RandomValue = new Random();
			Dice myDice = new Dice();

            myDice.StartSimulation(6, 1);
        }
    }
}