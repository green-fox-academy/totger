using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            Console.WriteLine("Adj meg egy szamot!");
            int num1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Adj meg egy masik szamot!");
			int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " a nagyobb");
            }
            else if (num1 < num2)
            {
                Console.WriteLine(num2 + " a nagyobb");
            }
            else
            {
                Console.WriteLine("A ket szam egyenlo");
            }
        }
    }
}