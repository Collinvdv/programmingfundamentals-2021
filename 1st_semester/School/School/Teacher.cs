using System;
namespace School
{
    public class Teacher : Person
    {
        public String Degree { get; set; }

        public Teacher(string personName, DateTime personBirthdate, Boolean personIsMarried, string degree, EnumGender personGender) : base(personName, personBirthdate, personIsMarried, personGender)
        {
            this.Degree = degree;
        }

        //
        public void Teach()
        {
            Console.WriteLine($"Look at me mom, I am teaching, I have a {this.Degree} degree");
        }

        public override void SayHello(string role = "teacher")
        {
            base.SayHello(role);
        }
    }
}
