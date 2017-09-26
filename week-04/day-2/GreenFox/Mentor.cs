﻿using System;
namespace GreenFox
{
    public class Mentor : Person
    {
        private string level;

        public Mentor(string Name, int Age, string Gender, string Level)
        {
			name = Name;
			age = Age;
			gender = Gender;
            level = Level;
        }

        public Mentor()
        {
			name = "Jane Doe";
			age = 30;
			gender = "female";
            level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} {3} mentor.", 
                             name, age, gender, level);
        }
    }
}
