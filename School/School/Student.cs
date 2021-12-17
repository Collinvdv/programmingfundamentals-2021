using System;
namespace School
{
    public class Student : Person
    {

        public Student(string personName, DateTime personBirthdate, Boolean personIsMarried, EnumGender personGender) : base(personName, personBirthdate, personIsMarried, personGender)
        {
        }

        // methods
        public override void SayHello(string role = "student")
        {
            base.SayHello(role);
        }
    }
}
