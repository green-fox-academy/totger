using System;
namespace GreenFox
{
    public class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public int NumberOfDays;

        public Student(string Name, int Age, string Gender, string PreviousOrganization)
        {
            name = Name;
            age = Age;
            gender = Gender;
            previousOrganization = PreviousOrganization;
            skippedDays = 0;

        }

        public Student()
        {
			name = "Jane Doe";
			age = 30;
			gender = "female";
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} age year old student from {2}" +
                              "who skipped {3} days from the course already."
                              , name, age, gender, previousOrganization, skippedDays );
        }
        public void SkipDays(int NumberOfDays)
        {
            skippedDays += NumberOfDays;
        }
    }
}
