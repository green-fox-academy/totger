using System;
using System.IO;

namespace WriteSingleLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"
            string path = "my-file.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Gergo Toth");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file");
            }
        }
    }
}
