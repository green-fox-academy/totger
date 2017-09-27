using System;
namespace Anagram
{
    public class Anagramma
    {
        public string Word1;
        public string Word2;

        public bool IsAnagram(string Word1, string Word2)
        {
            char[] char1 = Word1.ToCharArray();
            char[] char2 = Word2.ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            Word1 = String.Concat(char1);
            Word2 = String.Concat(char2);

            if (Word1 == Word2) return true;

            return false;
        }
    }
}
