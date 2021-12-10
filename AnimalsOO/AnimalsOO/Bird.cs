using System;
namespace AnimalsOO
{
    public class Bird: Animal
    {
        public Boolean hasFeathers { get; set; }

        // constructor
        public Bird(string animalName, string animalSex, Boolean animalHasFeathers) : base(animalName, animalSex)
        {
            hasFeathers = animalHasFeathers;
        }

        // methods
        public void GiveEgg()
        {
            if (IsAlive)
            {
                if (Sex == "female")
                {
                    Console.WriteLine("I am pushing, pushing pushing.. Here is your egg");
                }
                else
                {
                    Console.WriteLine("Who do you think I am? I am a guy, brah");
                }
            }
        }

        public override void Speak()
        {
            if (IsAlive)
            {
                Console.WriteLine("tok tok tok ");
            }
        }
    }
}

// CREATE A FISH
// poke the fish
// let the fish swim -> output: lalala, I am swimming in the ocean
// The fish name is Nemo and he is male