using System;
using System.Collections.Generic;

namespace GreenFox
{
    public class PallidaClass
    {
        private string className;
        private List<Student> students; new List<Student>();
        private List<Mentor> mentors; new List<Mentor>();

        public PallidaClass(string ClassName)
        {
            className = ClassName;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida {0} class has {1} students and {2} mentors." ,
                              className, students.Count, mentors.Count);
        }
    }
}
