using System;
namespace Lesson11_animals
{
    // inherit everything from animal : Class
    public class Fish : Animal
    {
        // ----------------
        // CONSTRUCTOR
        // ----------------
        public Fish(string name, DateTime dob, SexEnumeration sex) : base(name, dob, sex)
        {
            // overwrite the maximum amount of slaps to 1, bcs fishes are weak animals
            this.MaximumAmountOfSlaps = 1;
        }

        // ----------------
        // METHODS
        // ----------------
        public void Swim()
        {
            if (this.IsAlive)
            {
                Console.WriteLine("Blub blub blub, I am swimming, lalala");
            } else
            {
                this.SayItIsDead();
            }
        }

        public override void MakeNoise()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"{this.Name} is saying blub blub");
            }
            else
            {
                this.SayItIsDead();
            }
        }
    }
}
