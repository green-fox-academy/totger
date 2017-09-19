using System;
using System.IO;

namespace PrintEachLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"
            string path = "my-file.txt";

            try
            {
                string content = File.ReadAllText(path);
            }
            catch (Exception)
            {
                Console.WriteLine("The fuck are you doing? try to refer to" +
                                  "an existing file!");
            }

		}
    }
}
