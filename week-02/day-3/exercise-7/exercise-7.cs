using System;
using System.Collections.Generic;

namespace Matchmaking
{
	public class Matchmaking
	{
		public static void Main(string[] args)
		{
			var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
			var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
			var order = new List<string>();

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            for (int i = 0; i < girls.Count; i++)
            {
                order.Add(girls[i]);
                //order.Add(boys[i]);
                for (int j = 0; j < boys.Count; j++)
                {
                    order.Add(boys[j]);
                }
            }


             foreach (string name in order)
            {
                Console.Write("{0}, ", name);
            }


		}
	}
}