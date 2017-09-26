using System;
namespace GreenFox
{
    public class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string Name, int Age, string Gender, string Company)
        {
			name = Name;
			age = Age;
			gender = Gender;
            company = Company;
        }

        public Sponsor()
        {
			name = "Jane Doe";
			age = 30;
			gender = "female";
            company = "Google";
            hiredStudents = 0;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} year old {2} who represents" +
                              " {3} and hired {4} students so far.", 
                              name, age, gender, company, hiredStudents);
        }

        public new void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents += 1;
        }
    }
}
