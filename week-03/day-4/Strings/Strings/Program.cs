using System;

namespace Strings
{
    class Program
    {
        static string output;
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            Console.WriteLine(StringChanger("dselfmdsfxXxylkmefyx"));
            Console.ReadLine();
        }

        public static string StringChanger(string input)
        {

            if (input.Length == 0) return output;
            if (input[0] == 'x')
            {
                output += 'y';
            }
            else
            {
                output += input[0]; 
            }
            return StringChanger(input.Substring(1));
        }
    }
}
