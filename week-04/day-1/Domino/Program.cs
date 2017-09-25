using System;
using System.Collections.Generic;
namespace Domino
{
	public class Dominoes
	{
		static void Main(string[] args)
		{
			var dominoes = InitializeDominoes();
			// You have the list of Dominoes
			// Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
			// Create a function to write the dominous to the console in the following format
			// eg: [2, 4], [4, 3], [3, 5] ...
			SortDomino(dominoes);
			Console.ReadLine();
		}
		public static List<Domino> InitializeDominoes()
		{
            var dominoes = new List<Domino>
            {
                new Domino(5, 2),
                new Domino(4, 6),
                new Domino(1, 5),
                new Domino(6, 7),
                new Domino(2, 4),
                new Domino(7, 1)
            };
            return dominoes;
		}
		public static void SortDomino(List<Domino> dominoes)
		{
			int[] domino = dominoes[0].GetValues();
			Console.Write("[" + domino[0] + ", " + domino[1] + "], ");
			for (int i = 0; i < dominoes.Count; i++)
			{
				foreach (var dom in dominoes)
				{
					if (domino[1] == dom.GetValues()[0])
					{
						Console.Write("[" + dom.GetValues()[0] + ", " + dom.GetValues()[1] + "], ");
						domino[0] = dom.GetValues()[0];
						domino[1] = dom.GetValues()[1];
					}
				}
			}
		}

	}
}