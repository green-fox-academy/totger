using System;
using System.IO;

namespace CountLines
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
            string filename = "my-text.txt";
            Console.WriteLine(LineCounter(filename));
		}

        private static int LineCounter(string filename)
        {
            try
            {
                string[] content = File.ReadAllLines(filename);
                return content.Length;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
