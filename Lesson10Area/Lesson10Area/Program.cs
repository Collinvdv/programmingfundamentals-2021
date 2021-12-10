using System;

namespace Lesson10Area
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Ask for the shape
            Console.WriteLine("What area calculate? [CIRCLE OR RECTANGLE]");
            string shape = Console.ReadLine();

            // Calculate shape
            switch (shape)
            {
                case "RECTANGLE":
                    // the input from the user
                    Console.WriteLine("Give me height:");
                    int inputHeight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Give me width:");
                    int inputWidth = Convert.ToInt32(Console.ReadLine());

                    // calculate the area
                    int areaRectangle = CalculateAreaOfRectangle(inputHeight, inputWidth);

                    // Output the result
                    PrintResult(areaRectangle);

                    break;

                case "CIRCLE":
                    // asked some input
                    Console.WriteLine("Give me the radius:");
                    double inputRadius = Convert.ToDouble(Console.ReadLine());

                    // calculate the area of a circle
                    double areaCircle = CalculateAreaOfCircle(inputRadius);

                    // output the result
                    PrintResult(Convert.ToInt32(areaCircle));
                    break;

                default:
                    Console.WriteLine("I don't recognise this shape");
                    break;
            }

        }

        // print the result
        static void PrintResult(int result)
        {
            Console.WriteLine($"The result is {result}!");
        }

        // Calculation of rectangle
        static int CalculateAreaOfRectangle(int height, int width)
        {
            // formula to calculate the area of rectangle
            int result = height * width;

            return result;
        }

        // Calculation of circle
        static double CalculateAreaOfCircle(double radius)
        {

            // formula to calculate the area of rectangle
            double result = (radius * radius) * Math.PI;

            return result;
        }
    }
}


// What area calculate? [CIRCLE OR RECTANGLE]
// I: rectangle
// area of rectangle
// height * width
// O: give me height
// I: 10
// O: give me width
// I: 5
// O: The result is 50

// calculateAreaOfRectangle(10, 5)


// What area calculate? [CIRCLE OR RECTANGLE]
// I: CIRCLE
// area of circle
// 
// O: give me radius
// I: 10
// O: The result is 31.4

// calculateAreaOfCircle(10)










// AWESOME BANDNAME GENERATOR with 3 words
// { "the", "a", "not", "all"} => give me 1 random item back
// { "ugly", "awesome", "nice", "perfect", "hardcore"} => give me 1 random item back
// { "pigeon", "student", "bird", "flower", "jebus", "santan"} => give me 1 random item back
// Command YES or ADD NEW  to add new band name, Command STOP to stop the game

// O: Hello to my crazy band generator

// O: You want to know a new band?
// I: YES
// O: the awesome jebus

// O: You want to know a new band?
// I: YES
// O: not ugly pigeon

// O: You want to know a new band?
// I: STOP
// O: THXBEY






// ROCK PAPER SCISSORS
// Beat the PC
// Rock wins over scissors
// Paper wins over rock
// Scissors wins over paper
// When user say STOP, stop the program

// O: Lets play a game of rock paper scissors
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






// TINDER
// Random person
//      name: 3 letters consonant-vowel-consonant (FE: JAN, WIM, LIV, LEV) => use 2 arrays 
//      age: random from 18 - 100 (FE 18)
// COMMANDS
//      LIST LIKES
//      LIST DISLIKES
//      NEXT PERSON
//      Stop

// O: WELCOME TO TINDER
// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: NEXT PERSON
// O: Jan, 30years old. [type LIKE, type DISLIKE)
// I: like
// O: I've added Jan to like array

// O: What do you want to do? [LIST LIKES, LIST DISLIKES, NEXT PERSON]
// I: NEXT PERSON
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


