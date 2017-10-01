using System;
using System.Collections.Generic;
namespace DiceSimulation
{
    public class Dice
    {
        static Random RandomValue = new Random();

        public List<int> dice = new List<int>();

        public Dice(int diceNum)
        {
            for (int i = 0; i < diceNum; i++)
            {
                dice.Add(RandomValue.Next(1, 7));
            }
        }

        public void RollAll()
        {
            for (int i = 0; i < dice.Count; i++)
            {
                dice[i] = RandomValue.Next(1, 7);
            }
        }

        public void RollOne(int i)
        {
            dice[i] = RandomValue.Next(1, 7);
        }

		public void RollAllUntilAllSixes()
		{
            while (!AreOnlySixes())		
            {
                RollAll();
			}
		}
         
		public bool AreOnlySixes()
		{
			foreach (int item in dice)
			{
				if (item != 6)
					return false;
			}
			return true;
		}

        public void OneByOneRecursive(int n)
        {
            while (dice[n] != 6)
            {
                RollOne(n);
            }
            if (n != 0)
                OneByOneRecursive(n - 1);
        }

		public void OneByOne()
		{
            for (int i = 0; i < dice.Count; i++)
			{
				while (dice[i] != 6)
				{
                    RollOne(i);
				}
			}
		}
		
        public void RerollExceptSixes()
		{
			List<int> reRoll = CreateRerollList();
            while (reRoll.Count > 0)
            {
				foreach (int index in reRoll)
				{
                    RollOne(index);
				}
                UpdateList(reRoll);
            }
		}

        public List<int> CreateRerollList()
		{
            List<int> reRoll = new List<int>();
            for (int i = 0; i < dice.Count; i++)
            {
                if (dice[i] != 6) 
                    reRoll.Add(i);
            }
            return reRoll;
		}

        public void UpdateList (List<int> reRoll)
        {
            for (int i = 0; i < reRoll.Count; i++)
            {
                if (dice[reRoll[i]] == 6)
				{
                    reRoll.RemoveAt(i);
				}        
            }
        }
    }
}
