using System;
namespace AnimalsOO
{
    public class Animal
    {
        // properties
        public string Name { get; set; }
        public string Sex { get; set; }
        public int CountOfPokes { get; set; }
        public int MaximumAmountOfPokes { get; set; }
        public Boolean IsAlive { get; set; }
        public Animal Lover { get; set; }

        // constructor
        public Animal()
        {
            Name = "an animal";
        }

        public Animal(string animalName, string animalSex)
        {
            Name = animalName;
            Sex = animalSex;
            CountOfPokes = 0;
            IsAlive = true;
            MaximumAmountOfPokes = 5;
        }

        public Animal(string animalName, string animalSex, Animal animalLover)
        {
            Name = animalName;
            Sex = animalSex;
            CountOfPokes = 0;
            IsAlive = true;
            MaximumAmountOfPokes = 5;
            Lover = animalLover;
        }

        // methods
        public void PokeIt()
        {
            CountOfPokes++;

            if (CountOfPokes > MaximumAmountOfPokes )
            {
                if (IsAlive)
                {
                    Console.WriteLine($"You killed {Name}");
                    IsAlive = false;
                } else
                {
                    Console.WriteLine("You are one filthy human being, the animal is already dead");

                }
            } else
            {
                Console.WriteLine($"aaaaaaaaauwtch that hurts, you have already poked {CountOfPokes} times");
            }
        }

        public string GetLoversName()
        {
            return Lover.Name;
        }

        public void FeedIt()
        {
            if (IsAlive)
            {
                Console.WriteLine($"{this.Name} likes foods");
            }
        }

        public virtual void Speak()
        {
            if (IsAlive)
            {
                Console.WriteLine("brrrrrrr");
            }
        }

        public void Resuscitate()
        {
            IsAlive = true;
            CountOfPokes = 0;
        }
    }
}

