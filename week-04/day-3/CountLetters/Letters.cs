using System;
using System.Collections.Generic;
namespace CountLetters
{
    public class Letters
    {
		public Dictionary<char, int> LetterCounter(string input)
		{
            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (output.ContainsKey(letter))
                {
                    output[letter]++;
                }
                else
                {
                    output.Add(letter, 1);
                }
            }
            return output;
        }
    }
}
