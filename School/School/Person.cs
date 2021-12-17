using System;
namespace School
{
    public class Person
    {
        // properties
        protected string Name { get; set; }
        private DateTime Birthdate { get; set; }
        private Boolean isMarried { get; set; }
        public EnumGender Gender { get; set; }

        // constructor
        public Person(string personName, DateTime personBirthdate, Boolean personIsMarried, EnumGender personGender)
        {
            this.Name = personName;
            this.Birthdate = personBirthdate;
            this.isMarried = personIsMarried;
            this.Gender = personGender;
        }

        // method
        public virtual void SayHello(string role)
        {
            if (this.Gender == EnumGender.Male)
            {
                Console.Write("He is saying: ");
            }
            else
            {
                Console.Write("She is saying: ");
            }

            Console.WriteLine($"Hello, I am a {role}, my name is {this.Name}");
        }

        public int GetAge()
        {
            int year = DateTime.Now.Year;
            int birthdateYear = this.Birthdate.Year;
        
            return year - birthdateYear;
        }
    }
}

// Person person1 = new Person("collin", new DateTime(), false)
// Collin, 30 years old, he is not married
// Henry, 21 years old, het is not married
// Mia, 18 years old, she is not married