using System;

namespace School
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Teacher person1 = new Teacher("Collin", new DateTime(1991, 3, 16), false, "Bachelor", EnumGender.Male);
            Student person2 = new Student("Henry", new DateTime(2000, 2, 19), false, EnumGender.Male);
            Student person3 = new Student("Mia", new DateTime(2002, 10, 27), false, EnumGender.Female);

            person1.SayHello();
            person2.SayHello();
            person3.SayHello();
        }
    }
}

// Collin, 30 years old, he is not married, he is a teacher
// Henry, 21 years old, he is not married, he is a student
// Mia, 18 years old, she is not married, she is a student

// Collin can greet: He is saying: Hello, i am a teacher, my name is Collin
// Mia can greet: She is saying: Hello, i am a student, my name is Henry
