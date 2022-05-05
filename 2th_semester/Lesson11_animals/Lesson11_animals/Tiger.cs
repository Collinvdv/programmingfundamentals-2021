using System;
namespace Lesson11_animals
{
    // inherit everything from animal : Class
    public class Tiger : Animal
    {
        // ----------------
        // CONSTRUCTOR
        // ----------------
        public Tiger(string tigerName, DateTime tigerDob, SexEnumeration tigerSex) : base(tigerName, tigerDob, tigerSex)
        {
            // overwrite the maximum amount of slaps to 1000, bcs tigers are strong animals
            this.MaximumAmountOfSlaps = 1000;
        }

        // ----------------
        // Methods
        // ----------------
        public void EatAnimal(Animal victim)
        {
            Console.WriteLine($"I am eating {victim.Name}");

            victim.IsAlive = false;
        }
    }
}
