using System;
using System.IO;

namespace CopyFile
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string path = "mytext.txt";
            string outcome = "othertext.txt";

            Console.WriteLine(FileCopy(path, outcome));
		}

        public static bool FileCopy(string path, string outcome)
        {
			string[] content = File.ReadAllLines(path);
            try
            {
               using (StreamWriter writer = new StreamWriter(outcome))
                {
                    for (int i = 0; i < content.Length; i++)
                    {
                        writer.WriteLine(content[i]);
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
