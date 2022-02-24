using System;
using System.Collections.Generic;

namespace Lesson10RockPaperScissors
{
    class MainClass
    {
        static string[] choices = { "ROCK", "SCISSORS", "PAPER"};

        public static void Main(string[] args)
        {
            // Users choice
            Console.WriteLine("Lets play a game of rock paper scissors");

            // Askins user choice
            Console.WriteLine("What sign are you going to use? [ROCK, PAPER, SCISSORS]");
            string userChoice = Console.ReadLine(); //ROCK

            // I will do this untill they say stop
            while (userChoice != "STOP")
            {
                // check if it is excisting
                string computerChoice = getRandomChoice();
                Console.WriteLine(computerChoice);

                // check who won
                getWinner(userChoice, computerChoice);

                // ask it again
                Console.WriteLine("What sign are you going to use? [ROCK, PAPER, SCISSORS]");
                userChoice = Console.ReadLine(); //ROCK
            }
        }

        static string getRandomChoice()
        {
            // get a random index
            Random random = new Random();
            int randomIndex = random.Next(0, choices.Length - 1); // 0, 1 ,2

            return choices[randomIndex];
        }

        static void getWinner(string userChoice, string computerChoice)
        {
            // this case computer and user has the same choice 
            if (userChoice == computerChoice)
            {
                Console.WriteLine("No winner at all");
            } else
            {
                if (
                    (userChoice == "ROCK" && computerChoice == "SCISSORS")
                    ||
                    (userChoice == "PAPER" && computerChoice == "ROCK")
                    ||
                    (userChoice == "SCISSORS" && computerChoice == "PAPER")
                )
                {
                    Console.WriteLine("USER WON");
                } else
                {
                    Console.WriteLine("PC WON");
                }
            }

            // 
        }
    }
}


// ROCK PAPER SCISSORS
// Beat the PC
// Rock wins over scissors
// Paper wins over rock
// Scissors wins over paper
// When user say STOP, stop the program
// When the user wins from the computer, stop the program

// O: Lets play a game of rock paper scissors
// 
// O: What sign are you going to use? [ROCK, PAPER, SCISSORS]
// I: ROCK
// O: COMPUTER RANDOMLY CHOSE PAPER
// O: COMPUTER WINS FROM USER

// O: What sign are you going to use? [ROCK, PAPER, SCISSORS]
// I: SCISSORS
// O: COMPUTER RANDOMLY CHOSE PAPER
// O: USER WINS FROM COMPUTER

// O: What sign are you going to use? [ROCK, PAPER, SCISSORS]
// I: SCISSORS
// O: COMPUTER RANDOMLY CHOSE SCISSORS
// O: NO WINNER AT ALL

// O: What sign are you going to use? [ROCK, PAPER, SCISSORS]
// I: STOP
// O: THXBEY