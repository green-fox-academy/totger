using System;
using System.Collections.Generic;
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

		public void GetSixes(int n)
        {
            while (Dices[n] != 6)
            {
                Reroll(n);
            }
			if (n == 0) return;
			GetSixes(n - 1);

        }
		
        public void GetSixes()
		{
			for (int i = 0; i < Dices.Length; i++)
			{
				while (Dices[i] != 6)
				{
					Reroll(i);
				}
			}
		}

		public void RollUntilSixes()
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

        public void SixesWithSave()
        {
            while (true)
            {
                List<int> reRoll = CreateRerollList();

                if (reRoll.Count == 0) return;

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

		public static void Main(string[] args)
		{
			RandomValue = new Random();
			Dice myDice = new Dice();
			myDice.GetCurrent();
			myDice.Roll();
			myDice.GetCurrent();
			myDice.GetCurrent(5);
			myDice.Reroll();
			myDice.GetCurrent();
			myDice.Reroll(4);
			myDice.GetCurrent();

           
            //myDice.GetSixes();
            myDice.RollUntilSixes();
            //myDice.SixesWithSave();
            Console.WriteLine(string.Join(",", Dices));

        }


    }
}