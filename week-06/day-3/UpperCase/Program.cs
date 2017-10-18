using System;
using System.Collections.Generic;
using System.Linq;

namespace UpperCase
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input = "Nem AkaRom Megint A sucCulentset";

            var output = GetUpperLettersQuery(input);
        }

        private static List<char> GetUpperLettersQuery(string input)
        {

            var output =
                (from letter in input
                 where char.IsUpper(letter)
                 select letter).ToList();

            return output;
        }
    }
}
