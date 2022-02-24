using System;
namespace Lesson10_OO
{
    public class Student
    {
        // properties
        private string Name;
        public Classroom Classroom;

        public Student(string name, Classroom classroom)
        {
            Name = name;
            Classroom = classroom;
        }

        
    }
}
