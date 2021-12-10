using System;

namespace lesson10BandGenerator
{
    class MainClass
    {
        static string[] words1 = { "the", "an", "not", "all" };
        static string[] words2 = { "ugly", "awesome", "nice", "perfect", "hardcore" };
        static string[] words3 = { "pigeon", "student", "bird", "flower", "jebus", "satan" };

        public static void Main(string[] args)
        {
            // Input of the user
            Console.WriteLine("Hello to my crazy band generator");

            // 
            string commando = askCommando();

            // Check while commando is yes 
            while (commando == "YES")
            {
                // create a random band name
                createRandomBandname();

                // ask it again
                commando = askCommando();
            }

            Console.WriteLine("THXBEY");
        }

        static string askCommando()
        {
            Console.WriteLine("You want to know a new band? [YES, STOP]");
            string commando = Console.ReadLine();

            return commando;
        }

        static void createRandomBandname()
        {
            // create a random band name
            string randomWord1 = randomWord(words1);
            string randomWord2 = randomWord(words2);
            string randomWord3 = randomWord(words3);

            Console.WriteLine($"{randomWord1} {randomWord2} {randomWord3}");
        }

        static string randomWord(string[] words)
        {
            // creating new instance of random
            Random random = new Random();

            // ask random number from 0 to the length of the array
            int randomIndex = random.Next(0, words.Length - 1 ); // 0, 1, 2 ,3 -> 1

            // return a word back
            return words[randomIndex]; //"a"
        }
    }
}

// AWESOME BANDNAME GENERATOR with 3 words
// { "the", "a", "not", "all"} => give me 1 random item back
// { "ugly", "awesome", "nice", "perfect", "hardcore"} => give me 1 random item back
// { "pigeon", "student", "bird", "flower", "jebus", "satan"} => give me 1 random item back
// Command YES to add new band name, Command STOP to stop the game

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