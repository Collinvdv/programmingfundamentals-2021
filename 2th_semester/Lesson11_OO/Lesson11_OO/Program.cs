using System;

namespace Lesson11_OO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // using a constructor with 4 parameters
            Person person1 = new Person("Collin", "Van der Vorst", new DateTime(1991, 4, 16), 1.94);

            person1.SayFullName();
            person1.SayAge();

            // old way 
            Person person2 = new Person(); // person2 is john doe 1991 1.40 cm
            person2.FirstName = "Lars"; // set part
            person2.LastName = "Nolf";
            person2.Height = 1.91;

            person2.SayFullName();
            person2.SayAge();


            Person person3 = new Person();

            Console.WriteLine(person1.GetAgeDifference(person2));
            Console.WriteLine(person3.GetAgeDifference(person2));

            // Create classroom
            Person[] studentsDSPS = new Person[] { person1, person2, person3 };
            ClassRoom dsps = new ClassRoom(studentsDSPS);

            Console.WriteLine(dsps.GetAvgHeightOfStudents());

            Person person4 = new Person("Collin", "Van der Vorst", new DateTime(1991, 4, 16));
            Console.WriteLine(person4.ToString());

        }
    }
}
