using System;
namespace Lesson11_animals
{
    public enum SexEnumeration
    {
        Male = 0,
        Female = 1
    }

    public class Animal
    {
        // ----------------
        // PROPERTIES
        // ----------------
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public Boolean IsAlive { get; set; } = true;
        public SexEnumeration Sex { get; set; }
        public int AmountOfSlaps { get; set; } = 0;
        public int MaximumAmountOfSlaps { get; set; } = 5;
        public Animal Partner { get; set; }

        // ----------------
        // CONSTRUCTOR
        // ----------------
        public Animal(string name, DateTime dob, SexEnumeration sex)
        {
            // Given when created an instance
            Name = name;
            DoB = dob;
            Sex = sex;
        }

        public Animal(string name, DateTime dob, SexEnumeration sex, Animal partner)
        {
            // Given when created an instance
            Name = name;
            DoB = dob;
            Sex = sex;
            Partner = partner;
        }

        // ----------------
        // METHODS
        // ----------------
        public void SayName()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"Hello I am {this.Name}");
            } else
            {
                this.SayItIsDead();
            }
        }

        public void AddPartner(Animal partner)
        {
            // changing the partner of instance itself
            this.Partner = partner;

            // changing the partner of the partner to itself
            partner.Partner = this;
        }

        public void CheckRelationship()
        {
            if (this.Partner == null)
            {
                Console.WriteLine("I am so alone");
            } else
            {
                Console.WriteLine($"I am in a relationship with {this.Partner.Name}");
            }
        }

        public void Ressurect()
        {
            if (this.IsAlive == false)
                this.IsAlive = true;
        }

        public virtual void MakeNoise()
        {
            if (this.IsAlive)
            {
                Console.WriteLine($"{this.Name} is making some noise");
            } else
            {
                this.SayItIsDead();
            }
        }

        public void SlapIt()
        {
            // slap it
            if (this.IsAlive)
            {
                Console.WriteLine("Autwch that hurts");
            } else
            {
                this.SayItIsDead();
            }

            // add amount of slap with 1 
            this.AmountOfSlaps++;

            // check if the animal died
            if (this.AmountOfSlaps >= this.MaximumAmountOfSlaps)
                this.IsAlive = false;
        }

        protected void SayItIsDead()
        {
            Console.WriteLine($"Sorry dude, it is dead, RIP {this.Name}");
        }
    }
}
