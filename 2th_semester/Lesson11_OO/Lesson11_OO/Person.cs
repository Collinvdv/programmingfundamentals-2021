using System;
namespace Lesson11_OO
{
    public class Person
    {
        // ******
        // Properties
        // ******
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }
        public double Height { get; set; }

        // ******
        // Constructors
        // ******
        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            DateOfBirth = new DateTime(1990, 1, 1);
            Height = 1.40;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth , double height = 2.00)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Height = height;
        }

        // ******
        // Methods
        // ******
        public void SayHello()
        {
            Console.WriteLine(FirstName + " is saying hello");
        }

        public void SayFullName()
        {
            Console.WriteLine(GetFullName());
        }

        public void SayAge()
        {
            int yearsOld = GetAge();

            Console.WriteLine($"I am {yearsOld} years old");
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge()
        {
            int yearsNow = DateTime.Now.Year;
            int dobYears = DateOfBirth.Year;

            return yearsNow - dobYears;
        }

        public int GetAgeDifference(Person otherPerson)
        {
            return Math.Abs(this.GetAge() - otherPerson.GetAge());
        }


        public override string ToString()
        {
            return GetFullName();
        }

    }
}
