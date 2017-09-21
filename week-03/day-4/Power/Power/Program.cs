using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.WriteLine(PowerN(2, 8));
            Console.ReadLine();
        }

        private static int PowerN(int baseNum, int power)
        {
            if (baseNum < 1 || power < 1) return 1;
            baseNum *= PowerN(baseNum, power - 1);
            return baseNum; 
        }
    }
}
