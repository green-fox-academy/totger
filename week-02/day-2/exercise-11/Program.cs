using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
            int[] r = { 1, 2, 3, 4, 5 };
            r[2]++;
            Console.WriteLine(r[2]);
        }
    }
}