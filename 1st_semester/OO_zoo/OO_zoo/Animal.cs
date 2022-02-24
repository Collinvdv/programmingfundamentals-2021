using System;
using System.Collections.Generic;

namespace OO_zoo
{
    public class Animal
    {
        // data
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        private Animal Partner { get; set; }
        public List<Animal> Friends { get; set; }

        // initial load or constructor
        public Animal(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;

            this.Friends = new List<Animal>();
        }

        // methods
        public void SayHello()
        {
            Console.WriteLine($"Hello I am an animal and my name is {this.Name}");
        }

        public void SayYears()
        {
            int currentYear = DateTime.Now.Year; // 2021
            int birthdateYear = this.BirthDate.Year; // year of the animal
            int years = currentYear - birthdateYear;

            Console.WriteLine($"I am {years} years old");
        }

        public void AddPartner(Animal partner)
        {
            this.Partner = partner;
        }

        public void CheckPartner()
        {
            if (this.Partner != null)
            {
                Console.WriteLine("I am in love with " + this.Partner.Name);
            } else
            {
                Console.WriteLine("I am Super lonely");
            }
        }

        public void ListFriends()
        {
            foreach(Animal animal in this.Friends)
            {
                Console.WriteLine("Friend is " + animal.Name);
            }
        }
    }
}

// 1.4
// Add friends
// Coco, 16/04/1991, partner is Lili, Animal
// Lili, 21/06/1993, partner is Coco, Fish
// Lonely pigeon, 21/08/2000, Animal, friends are coco and lili