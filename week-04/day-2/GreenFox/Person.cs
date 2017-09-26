using System;
namespace GreenFox
{
    public class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person(string Name, int Age, string Gender)
        {
            name = Name;
            age = Age;
            gender = Gender;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
           
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm {0}, a {1} age year old {2}", name, age, gender);
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
