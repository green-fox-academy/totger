using System;

namespace anagram
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string word1 = GetWord();
            string word2 = GetWord();
            char[] firstWord = WordToArray(word1);
            char[] secondWord = WordToArray(word2);
            //bool result = ;
            if (Evaluate(firstWord, secondWord))
                Console.WriteLine("Cool, they are anagrams!");
            else
                Console.WriteLine("So bad, they are not anagrams!");
        }

            public static char[] WordToArray(string word)
        {
            int length = word.Length;
            char[] characters = word.ToCharArray();
            return characters;
        }

        public static string GetWord()
        {
            Console.WriteLine("Please type in the your word:");
            string word = Console.ReadLine();
            return word;
        }

        public static bool Evaluate(char[] firstWord, char[] secondWord)
        {
            if (firstWord.Length != secondWord.Length)
                return false;
            Array.Sort(firstWord);
            Array.Sort(secondWord);
            for (int i = 0; i < firstWord.Length - 1; i++)
            {
                if (firstWord[i] != secondWord[i])
                    return false;
            }
            return true;

        }
    }
}
