using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).           
            Console.WriteLine(BunnyEars(4));
            Console.ReadLine();
        }

        private static int BunnyEars(int number)
        {
            if (number == 0) return 0;
            return 2 + BunnyEars(number - 1);
        }
    }
}
