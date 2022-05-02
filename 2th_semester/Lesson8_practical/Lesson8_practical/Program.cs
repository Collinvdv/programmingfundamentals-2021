using System;
using System.Collections.Generic;

namespace Lesson8_practical
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //
            // Exercise:
            // O: Input a lot of grades, say stop to exit the program
            // I: 10
            // I: 20
            // I: 15
            // I: STOP
            // O: The average is 15
            //

            //Console.WriteLine("Input a lot of grades, say stop to exit the program");

            //string commando = "";
            //List<int> gradebook = new List<int>();

            //// Populate the list
            //while (commando != "stop")
            //{
            //    commando = Console.ReadLine();

            //    int grade;

            //    bool success = int.TryParse(commando, out grade);

            //    if (success)
            //    {
            //        gradebook.Add(grade);
            //    }
            //}

            //// calculate avg
            //double avg = 0;
            //double totalGrades = 0;

            //foreach (int grade in gradebook)
            //{
            //    totalGrades += grade;
            //}

            //avg = totalGrades / gradebook.Count;

            //Console.WriteLine($"The avg is {avg} ");



            //
            // Exercise:
            // Gradebook
            // COMMANDS
            //     [ADD STUDENT] [ADD GRADE] [AVERAGE STUDENTS] [AVERAGE GRADES] [LIST STUDENTS] [STOP]
            //
            // I: ADD STUDENT
            // O: What is the name of the student?
            // I: Collin
            // O: Collin added
            //
            // I: ADD STUDENT
            // O: What is the name of the student?
            // I: Elvis
            // O: Elvis added
            //
            // I: ADD GRADE
            // O: For what student?
            // I: Collin
            // O: What result
            // I: 15
            //
            // I: ADD GRADE
            // O: For what student?
            // I: Elvis
            // O: What result
            // I: 17
            //
            // I: AVERAGE STUDENTS
            // O: Avg collin is 15
            // O: Avg elvis is 17
            //
            // I: AVERAGE GRADES
            // O: Avg test 16
            //
            // I: LIST STUDENTS
            // O: Students are Collin, Elvis

            //Dictionary<string, List<int>> gradebook = new Dictionary<string, List<int>>();

            //string commando = Console.ReadLine();

            //string student = "";

            //while (commando != "stop")
            //{
            //    // Check the commando
            //    switch(commando.ToLower())
            //    {
            //        case "add student":
            //            // add the student
            //            Console.WriteLine("What is the name of the student?");
            //            student = Console.ReadLine();
            //            List<int> emptyGrades = new List<int>();

            //            gradebook.Add(student, emptyGrades);
            //            break;
            //        case "add grade":
            //            // asking students name
            //            Console.WriteLine("For who?");
            //            student = Console.ReadLine(); // fe: collin

            //            // asking result
            //            Console.WriteLine("What result?");
            //            int grade = Convert.ToInt16(Console.ReadLine()); // fe: 15

            //            // add the grade to collin inside of the gradebook
            //            gradebook[student].Add(grade);

            //            Console.WriteLine(gradebook[student].ToString());
            //            break;
            //        case "average students":
            //            // loop every student and calculate the avg
            //            foreach(var studentPair in gradebook)
            //            {
            //                student = studentPair.Key;

            //                double totalGrades = 0;
            //                double avg = 0;

            //                foreach (int studentGrade in studentPair.Value )
            //                {
            //                    totalGrades += studentGrade;
            //                }

            //                avg = totalGrades / studentPair.Value.Count;

            //                Console.WriteLine($"{student} the average is {avg}");

            //            }
            //            break;

            //    }
            //    // Ask a new commando
            //    commando = Console.ReadLine();

            //7 3
            //Tsi
            //h % x
            //i #
            //sM 
            //$a
            //#t%
            //ir!

            //Console.WriteLine("Give me some dimensions");
            //string[] dimensions = Console.ReadLine().Split(); // 7 3 => ["7", "3"]
            //int rows = Convert.ToInt16(dimensions[0]); // int 7
            //int columns = Convert.ToInt16(dimensions[1]); // int 3

            //List<string> input = new List<string>();

            //// populating every input inside input
            //for(int index = 0; index < rows; index++)
            //{
            //    string word = Console.ReadLine();
            //    input.Add(word);
            //}

            //// make 1 big string => This$#is  Matri%#  
            //string fullPhrase = "";

            //for (int columnIndex = 0; columnIndex < columns; columnIndex++)
            //{
            //    for(int rowIndex = 0; rowIndex < rows; rowIndex++)
            //    {
            //        fullPhrase += input[rowIndex][columnIndex]; 
            //    }
            //}

            // Create the final result
            string fullPhrase = "This$#is% Matrix#  %";
            string finalPhrase = "";
            Boolean prevCharacterIsCharacter = true;

            foreach (char character in fullPhrase)
            {
                Boolean isChar = Char.IsLetterOrDigit(character);

                if (isChar)
                {
                    finalPhrase += character; 
                } else
                {
                    if (prevCharacterIsCharacter)
                    {
                        finalPhrase += " ";
                    }
                }

                prevCharacterIsCharacter = isChar;
            }
            Console.WriteLine(finalPhrase);

        }
    }
}









































//
// Exercise:
// https://thomasmore.instructure.com/courses/17953/assignments/175512
//



















//
// Is python that different?
// NO!
//






//
// Excercise:
// Spotify
// COMMANDS
//     ADD A SONG
//     LIST ALL ARTISTS
//     LIST ALL SONGS OF ARTIST
//     STOP

// I: ADD A SONG
// O: Name of artist:
// I: Justin Bwieber
// O: Name of song:
// I: Baby
// O: Justin Bwieber - Baby has been added
//
// I: ADD A SONG
// O: Name of artist:
// I: Justin Bwieber
// O: Name of song:
// I: Adult
// O: Justin Bwieber - Adult has been added
//
// I: LIST ALL ARTISTS
// O: 1. Justin Bwieber
//
// I: LIST ALL SONGS OF ARTIST
// I: Justin Bwieber
// O: 1. Baby
// O: 2. Adult
//
// I: STOP
// O: ThxBye
//
//
// I: ADD A SONG
// O: Name of artist:
// I: Justin Bwieber
// O: Name of song:
// I: Adult
// O: Song adult for Justin Bwieber is already added!
//














//
// Make life even more harder 
// Part 2 Spotify to file
// Save everything to 1 file
//




