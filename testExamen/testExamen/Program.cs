using System;
using System.Collections.Generic;
using System.IO;

namespace testExamen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            switch(command)
            {
                case "trial1":
                    assignment1();
                    break;
                case "trial2":
                    assignment2();
                    break;
            }
        }

        public static void assignment1()
        {
            // read file + till the end
            StreamReader nameFile = File.OpenText("Names.txt");
            string fullText = nameFile.ReadToEnd();

            // strip " + create an array by , seperation
            fullText = fullText.Replace("\"", "");
            string[] names = fullText.Split(',');

            // Ask for the input name + toUpper to check later
            string inputName = Console.ReadLine();
            inputName = inputName.ToUpper();

            // Create new list for all the input
            List<string> outputnames = new List<string>();

            // loop over all names
            foreach (string name in names)
            {
                // check if all letters are 
                Boolean hasAllLetters = true;

                // check every letter seperately
                foreach(char letter in inputName)
                {
                    Boolean checkLetter = name.Contains(Convert.ToString(letter));

                    if (checkLetter == false) hasAllLetters = false;
                }

                // if it has all the letters then  everything is allright
                if (hasAllLetters) outputnames.Add(name);
            }

            // We have to sort them
            outputnames.Sort();

            // Output array
            foreach(string name in outputnames)
            {
                Console.Write(name + " ");
            }

        }

        public static void assignment2()
        {
            // Get the number
            int number = Convert.ToInt32(Console.ReadLine());
            string nextPalindrome = "";

            // check until palindrome is a success
            while (nextPalindrome == "")
            {
                // go to next number
                number++;

                // check palindrome
                string originalNumber = Convert.ToString(number);
                string reversedNumber = "";

                // reversed the number
                for (int i = originalNumber.Length - 1; i >= 0; i--)
                {
                    reversedNumber += originalNumber[i];

                }

                // if number is the same add to string
                if (originalNumber == reversedNumber)
                {
                    nextPalindrome = originalNumber;
                }
            }

            // The actual output
            Console.WriteLine("Next palindrome is: " + nextPalindrome);
        }

    }
}
