using System;

namespace anagram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 1;
            string word1 = GetWord(count);
            count++;
            string word2 = GetWord(count);
            Console.WriteLine("{0}, {1}", word1, word2);

        }

        private static string GetWord(int count)
        {
            Console.WriteLine("Please type in the {0}. word:", count);
            string word = Console.ReadLine();
            return word;
        }
    }
}
