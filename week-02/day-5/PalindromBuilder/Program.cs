using System;

namespace PalindromBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CreatePalindrom());
        }

        private static string CreatePalindrom()
        {
            string input = GetWord();
            char[] characters = input.ToCharArray();
            char[] reversedCharacters = new char[characters.Length];
            int j = characters.Length - 1;
            for (int i = 0; i < characters.Length; i++)
            {
                reversedCharacters[j] = characters[i];
                j--;
            }
            string reversed = new string(reversedCharacters);
            return input += reversed;
        }

        private static string GetWord()
        {
            Console.WriteLine("Type in the word to get a palindrom:");
            return Console.ReadLine();
        }
    }
}
