using System;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(EarCount(12));
            Console.ReadLine();
        }

        private static int EarCount(int num)
        {
            if (num == 0) return 0;
            if (num % 2 == 1) return 2 + EarCount(num - 1);
            return 3 + EarCount(num - 1);
        }
    }
}
