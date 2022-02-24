using System;
using System.Collections.Generic;

namespace Lesson10Tinder
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            // create empty lists
            List<string> likes = new List<string>();
            List<string> dislikes = new List<string>();

            // ask for command
            string command = AskCommand();

            while (command != "STOP")
            {
                switch (command)
                {
                    case "SWIPE":
                        // create new person
                        string name = RandomName();
                        int age = RandomAge();

                        // Name + age
                        Console.WriteLine($"{name}, {age}years old. [type LIKE, type DISLIKE)");

                        // ask the user to like or dislike the person
                        string swipeCommand = Console.ReadLine();
                        Swipe(swipeCommand, likes, dislikes, name);

                        break;

                    case "LIST LIKES":
                        ListArray(likes);
                        break;

                    case "LIST DISLIKES":
                        ListArray(dislikes);
                        break;

                    default:
                        Console.WriteLine("Can not find the command");
                        break;
                }

                // ask the command again
                command = AskCommand();
            }

            // Say goodbey
            Console.WriteLine("ThxBey");
        }

        static string AskCommand()
        {
            Console.WriteLine("What do you want to do? [LIST LIKES, LIST DISLIKES, SWIPE]");
            return Console.ReadLine();
        }

        static string RandomName()
        {
            // make arrays for custom vowels
            string[] vowels = { "a", "e", "o", "u", "i" };
            string[] consonant = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "r", "s", "t", "v", "w", "x", "z" };

            // create random 
            Random random = new Random();

            // find random letters
            string letter1 = consonant[random.Next(0, consonant.Length - 1)];
            string letter2 = vowels[random.Next(0, vowels.Length - 1)];
            string letter3 = consonant[random.Next(0, consonant.Length - 1)];

            // name
            return $"{letter1}{letter2}{letter3}";
        }

        static int RandomAge()
        {
            Random random = new Random();

            return random.Next(18, 100);
        }

        static void Swipe(string command, List<string> likes, List<string> dislikes, string person)
        {
            if (command == "LIKE")
            {
                likes.Add(person);
            } else
            {
                dislikes.Add(person);
            }
        }

        static void ListArray(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}


// TINDER
// Random person
//      name: 3 letters consonant-vowel-consonant (FE: JAN, WIM, LIV, LEV) => use 2 arrays
//      age: random from 18 - 100 (FE 18)
// COMMANDS
//      LIST LIKES
//      LIST DISLIKES
//      SWIPE

// O: WELCOME TO TINDER

// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: SWIPE
// O: Jan, 30years old. [type LIKE, type DISLIKE)
// I: like
// O: I've added Jan to like array

// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: SWIPE
// O: Liv, 23years old. [type LIKE, type DISLIKE)
// I: DISLIKE
// O: I've added Liv to dislike array

// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: LIST LIKES
// O: JAN

// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: LIST DISLIKES
// O: LIV

// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: STOP
// O: THXBEY