using System;

namespace GreenFox
{
	class Program
	{
		static void Main(string[] args)
		{
			// Swap the values of the wariables
			int a = 123;
			int b = 526;
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine(a);
            Console.WriteLine(b);
		}
	}
}