using System;
using System.Collections.Generic;

namespace Calculator
{
	public class Calculator
	{
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
            Console.WriteLine("Please type in the expression:");

            string input = Console.ReadLine();
            string.Split
            //var input = new List<object>();
            //string op = Console.ReadLine();
            //int operand1 = Convert.ToInt32(Console.ReadLine());
            //int operand2 = Convert.ToInt32(Console.ReadLine());

            input.Add(op);
            input.Add(operand1);
            input.Add(operand2);


            Console.WriteLine();
            //Console.WriteLine(input[2]);



            if (op == "+")
                Console.WriteLine(operand1 + operand2);
            else if (op == "*")
                Console.WriteLine(operand1 * operand2);
            else if (op == "-")
                Console.WriteLine(operand1 - operand2);
            else if (op == "/")
                Console.WriteLine(operand1 / operand2);
            else if (op == "%")
                Console.WriteLine(operand1 % operand2);
            else
                Console.WriteLine("Next time add a normal operand, loser!");
        }
    }
}