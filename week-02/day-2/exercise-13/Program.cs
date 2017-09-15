using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] matrix = new int[4, 4];
            int second = 0;

            for (int first = 0; first < 4; first++)
            {
                if (first == second)
                    matrix[first, second] = 1;
                else
                    matrix[first, second] = 0;
                second++;
            }
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

			for (int i = 0; i < rowLength; i++)
            {
				for (int j = 0; j < colLength; j++)
				{
                    Console.Write(string.Format("{0} ", matrix[i, j]));
				}
				Console.WriteLine();
            }


        }
    }
}