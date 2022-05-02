using System;

namespace Lesson10_theory
{
    class MainClass
    {
        static int height = 50;
        static int[] incomes = { 100, 2000, 3000 };

        public static void Main(string[] args)
        {
            // Random numbers
            int[] randomNumbers = RandomList(10, -100, 101);
            Print(randomNumbers);

            // loop over the first array
            int[] numbers1 = { 5, 6, 7, 10 };
            Print(numbers1);
            
            // loop over the first array
            int[] numbers2 = { 15, 46, 47, 10 };
            Print(numbers2);

            // loop over array of strings
            string[] names = { "Collin", "Lisa", "Mohammed" };
            Print(names);


        }

        static void Print(int[] items)
        {
            Console.Write("Items are: ");
            foreach (int item in items)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("");
        }

        static void Print(string[] items)
        {
            Console.Write("Words are: ");
            foreach (string item in items)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }

        static int[] RandomList(int length = 10, int minimumValue = 0, int maximumValue = 100)
        {
            int[] numbers = new int[length]; // { 0, 0, 0, 0}

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = RandomNumber(minimumValue, maximumValue);
            }

            Array.Sort(numbers);

            return numbers;
        }

        static int RandomNumber(int minimumValue = 0, int maximumValue = 100)
        {
            Random randomNumber = new Random();

            return randomNumber.Next(minimumValue, maximumValue);
        }
    }
}

//
//  List numbers
//  












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
