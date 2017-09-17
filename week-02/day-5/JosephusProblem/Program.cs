using System;
using System.Collections.Generic;
namespace JosephusProblem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			List<int> people = new List<int>();
			int input = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < input; i++)
			{
				people.Add(i + 1);
			}

            Console.WriteLine(GetWinner(people));
        }

        private static int GetWinner(List<int> people)
        {
            if (people.Count == 1)
            {
                return people[0];
            }
            for (int i = 0; i < people.Count; i++)
            {
                if (i % 2 == 1)
                    people[i] = 0;
            }
            if (people[people.Count - 1] != 0)
            {
                people.Insert(0, people[people.Count - 1]);
                people.RemoveAt(people.Count - 1);
            }                
            for (int j = 0; j < people.Count; j++)
			{
                if (people[j] == 0)
					people.RemoveAt(j);
			}
            return GetWinner(people);
		}          
    }
}
