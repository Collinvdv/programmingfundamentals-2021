using System;
namespace OO_zoo
{
    public class Fish : Animal
    {
        // constructor which passes to parent class
        public Fish(string name, DateTime birthDate) : base(name, birthDate)
        {
        }

        // methods
        public void Swim()
        {
            Console.WriteLine("Lalalalalalala, I am swimming");
        }
    }
}
