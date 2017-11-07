using System;
namespace APIworkshop.Models
{
    public class JsonObject
    {
        public int Until { get; set; }

        public int Factorial(int Until)
        {
            if (Until == 1) return 1;

            return Until * Factorial(Until - 1);
        }

        public int Sum(int Until)
        {
            int result = 0;
            for (int i = 1; i <= Until; i++)
            {
                result += i;
            }
            return result;
        }
    }
}
