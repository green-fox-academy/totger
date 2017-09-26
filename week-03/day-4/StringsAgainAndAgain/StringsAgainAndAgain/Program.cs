using System;

namespace StringsAgainAndAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(StringChanger("dsgfddjngdf"));
            Console.ReadLine();
        }

        public static string StringChanger(string input)
        {
            if (input.Length == 1) return input;
            return input[0] + "*" + StringChanger(input.Substring(1));
        }
    }
}
