using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            Console.WriteLine(StringChanger("dselfmdsfxXxylkmefyx"));
            Console.ReadLine();
        }

        public static string StringChanger(string input)
        {
            if (input.Length == 0) return input;
            if (input[0] == 'x') return 'y' + StringChanger(input.Substring(1));
            return input[0] + StringChanger(input.Substring(1));    
        }
    }
}
