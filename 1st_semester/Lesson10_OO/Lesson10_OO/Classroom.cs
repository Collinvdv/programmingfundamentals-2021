using System;
namespace Lesson10_OO
{
    public class Classroom
    {
        public string Name { get; set; }
        public Student[] Students { get; set; }

        public Classroom(string name)
        {
            Name = name;
        }
    }
}
