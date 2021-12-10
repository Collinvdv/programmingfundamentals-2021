using System;
namespace AnimalsOO
{
    public class Fish : Animal
    {
        // constructor
        public Fish(string fishName, string fishSex) : base(fishName, fishSex)
        {
        }

        public Fish(string fishName, string fishSex, Animal animal) : base(fishName, fishSex, animal)
        {
        }

        // method
        public void Swim()
        {
            if (IsAlive)
            {
                Console.WriteLine($"Lalalala, {Name} is swimming");
            }
        }

        public override void Speak()
        {
            if (IsAlive)
            {
                Console.WriteLine("blub blub blub");
            }
        }
    }
}
