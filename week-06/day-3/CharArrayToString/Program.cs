using System;
using System.Linq;

namespace CharArrayToString
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] input = { 'a', 'o', 'k', 'p', 'x' };
            string output = ToString(input);
        }

        private static string ToString(char[] input)
        {
            return String.Join("", input.Select(x => x));
        }
    }
}
