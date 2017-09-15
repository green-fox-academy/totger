using System;
using System.Collections.Generic;
namespace JosephusProblem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> people = new List<int>();
            int contestant = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < contestant; i++)
            {
                people.Add(i + 1);
            }
            for (int i = 1; i < people.Count; i += 2)
            {
                people[i] = 0;
            }
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }

        }
    }
}
