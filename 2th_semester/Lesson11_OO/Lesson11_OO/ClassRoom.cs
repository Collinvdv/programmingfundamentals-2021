using System;
namespace Lesson11_OO
{
    public class ClassRoom
    {
        // ******
        // Properties
        // ******
        public Person[] Students { get; set; }

        // ******
        // Constructors
        // ******
        public ClassRoom(Person[] students)
        {
            this.Students = students;
        }

        // ******
        // Methods
        // ******
        public int GetAmountOfStudents()
        {
            return Students.Length;
        }

        public double GetAvgHeightOfStudents()
        {
            double totalHeight = 0;

            foreach(Person student in Students)
            {
                totalHeight += student.Height;
            }

            return totalHeight / GetAmountOfStudents();
        }
    }
}
