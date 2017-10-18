using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterFrequency
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "hello world";

            var output = GetCharFreqLambda(input);
            var outputQuery = GetCharFreqQuery(input);
        }

        private static Dictionary<char, int> GetCharFreqQuery(string input)
        {
            return
                (from character in input.Where( x => !char.IsWhiteSpace(x))
                 group character by character into o
                 select new { o.Key, Value = o.Count() })
                .ToDictionary(x => x.Key, x => x.Value);

        }
        private static Dictionary<char, int> GetCharFreqLambda(string input)
        {
            Dictionary<char, int> output = new Dictionary<char, int>();

            foreach (var character in input
                     .Where(character => !char.IsWhiteSpace(character))
                     .Distinct())
            {
                output.Add(character, input.Count( x => x == character));
            }

            return output;
        }
    }
}
