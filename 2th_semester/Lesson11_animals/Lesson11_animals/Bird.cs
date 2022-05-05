using System;
namespace Lesson11_animals
{
    // inherit everything from animal : Class
    public class Bird : Animal
    {
        // ----------------
        // CONSTRUCTOR
        // ----------------
        public Bird(string name, DateTime dob, SexEnumeration sex) : base(name, dob, sex)
        {
            // overwrite the maximum amount of slaps to 2, bcs fishes are weak animals
            this.MaximumAmountOfSlaps = 2;
        }

        // ----------------
        // METHODS
        // ----------------
        public void LayEgg()
        {
            if (this.Sex == SexEnumeration.Female)
            {
                Console.WriteLine("Auuuuuuwtch, here is the egg");
            } else
            {
                Console.WriteLine("Dude, r u kidding me? I am a male.");
            }
        }
    }
}
