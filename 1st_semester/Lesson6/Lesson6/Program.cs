using System;

namespace Lesson6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //// Exercise 1
            //// 10 grades: 10,4,3,4,8,9,8,7,6,5
            //int[] grades = new int[10]; //created an array of 10 items
            //// grades = {0, 0, 0, 0, 0, 0, .. }
            //grades[0] = 10; //at index 0 store the value 10
            //// grades = {10, 0, 0, 0, 0, 0, .. }
            //grades[1] = 4; //at index 0 store the value 10
            //grades[2] = 3;
            //grades[3] = 4;
            //grades[4] = 8;
            //grades[5] = 9;
            //grades[6] = 8;
            //grades[7] = 7;
            //grades[8] = 6;
            //grades[9] = 5;

            //int[] grades2 = { 10, 4, 3, 4, 8, 9, 8, 7, 6, 5};
            ////grades[10] = 4; NOT POSSIBLE BECAUSE ARRAY IS ONLY 10 ITEMS LONG

            //// First grade
            //Console.WriteLine(grades[0]);
            //Console.WriteLine(grades[1]);
            //Console.WriteLine(grades2[0]);
            //Console.WriteLine(grades2[1]);

            //// Exercise 2
            //// 4 characters Harry Potter, Ron Weasley, Hermione Granger, Voldemort
            //// in a variable characters
            //// Output:
            //// Harry Potter
            //// Ron Weasley
            //// Hermione Granger
            //// Voldemort

            ////string[] characters = new string[4]; // {"", "", "", ""}
            ////characters[0] = "Harry Potter"; // {"Harry Potter", "", "", ""}
            ////characters[1] = "Ron Weasley"; // {"Harry Potter", "Ron Weasley", "", ""}
            ////characters[2] = "Hermione Granger"; // {"Harry Potter", "Ron Weasley", "Hermoine Granger", ""}
            ////characters[3] = "Voldemort"; // {"Harry Potter", "Ron Weasley", "Hermoine Granger", "Voldemort"}

            ////Console.WriteLine(characters[0]);
            ////Console.WriteLine(characters[1]);
            ////Console.WriteLine(characters[2]);
            ////Console.WriteLine(characters[3]);

            //string[] characters = { "Harry Potter", "Ron Weasley", "Hermoine Granger", "Voldemort", "Hagrid" };

            ////Console.WriteLine(characters[0]);
            ////Console.WriteLine(characters[1]);
            ////Console.WriteLine(characters[2]);
            ////Console.WriteLine(characters[3]);


            //// Exercise 3
            //// 4 characters Harry Potter, Ron Weasley, Hermione Granger, Voldemort
            //// Change Voldemort name to Dombledore
            //// Put them in a list
            //// output them manually
            //// Harry Potter
            //// Ron Weasly
            //// Hermione Granger
            //// Dombledore
            //characters[3] = "Dombledore";

            ////Console.WriteLine(characters[0]);
            ////Console.WriteLine(characters[1]);
            ////Console.WriteLine(characters[2]);
            ////Console.WriteLine(characters[3]);

            //Console.WriteLine("Character array is " + characters.Length + " items long");

            //for (int index = 0; index < characters.Length; index++)
            //{
            //    string character = characters[index];
            //    Console.WriteLine(character);
            //    Console.WriteLine(character);
            //    Console.WriteLine(character);
            //}

            ////int characterIndex = 0;

            ////while (characterIndex < characters.Length)
            ////{
            ////    // execute code
            ////    Console.WriteLine(characters[characterIndex]);

            ////    // go to the next character
            ////    characterIndex++; // +1

            ////}

            //foreach (string character in characters) //character = characters[3]
            //    Console.WriteLine(character);
            //}
            ////Console.WriteLine($"These are my main characters: {characters[0]} {characters[1]} {characters[2]} {characters[3]}");


            // Exercise 7
            // Students
            // user input: number of students : 3
            // user input: number of students X name
            //int studentCount = Convert.ToInt32(Console.ReadLine());
            //string[] students = new string[studentCount];

            //// input of data in array
            //for (int index = 0; index < students.Length; index++)
            //{
            //    students[index] = Console.ReadLine();
            //}

            //// output of data in array
            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}


            //// Exercise 8
            //// input: number of students (FE:5)
            //// input: 8 (grade of student 1)
            //// input: 10 (grade of student 2)
            //// input: 8 (grade of student 3)
            //// input: 5
            //// input: 3
            //// output: average (sum of the grades / amount of grades ) (FE 34/5)

            ////// Declaration of variables
            ////int numberOfStudent = Convert.ToInt32(Console.ReadLine()); // FE numberOfStudents 5
            ////int[] grades = new int[numberOfStudent]; // {0, 0, 0, 0, 0}

            ////// Input of the grades
            ////for (int index = 0; index < grades.Length; index++)
            ////{
            ////    grades[index] = Convert.ToInt32(Console.ReadLine());
            ////}

            ////// Calculation of the average
            ////double sumOfGrades = 0;

            ////for (int index = 0; index < grades.Length; index++)
            ////{
            ////    sumOfGrades += grades[index];
            ////}

            ////// output
            ////double average = sumOfGrades / numberOfStudent;
            ////Console.WriteLine(sumOfGrades);
            ////Console.WriteLine(numberOfStudent);
            ////Console.WriteLine(average);

            //// give me 5 names
            //// input: Collin Jesus Brad Tom
            ////Console.WriteLine("Give me names (hyphen seperated)");
            ////string names = Console.ReadLine();
            ////string[] namesArray = names.Split('-');

            ////Console.WriteLine(namesArray[0]);

            //// give 5 grades
            //// input 4,5,8,10,5
            //Console.WriteLine("Give me grades (comma seperated)");
            //string[] gradesAsString = Console.ReadLine().Split(','); //4,5,8,10,5
            ////int[] gradesAsInteger = new int[gradesAsString.Length]; // {0, 0, 0, 0, 0}


            ////for(int index = 0; index < gradesAsInteger.Length; index++)
            ////{
            ////    gradesAsInteger[index] = Convert.ToInt16(gradesAsString[index]);
            ////}


            //int[] gradesAsInteger = Array.ConvertAll(gradesAsString, Int32.Parse);

            //Console.WriteLine(gradesAsInteger[0]);



            //int[] grades = { 5, 10, 4, 5, 3 };
            //Array.Sort(grades);

            //foreach(int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}


            //// Student1 row(0): 5, 10, 8, 5
            //// Student2: 0, 10, 5, 7

            //int amountOfStudents = 2;
            //int amountOfTest = 4;
            //int[,] grades = new int[amountOfStudents, amountOfTest];

            //// Student 1
            //grades[0,0] = 5; //test1
            //grades[0,1] = 10; //test2
            //grades[0,2] = 8; //test3
            //grades[0,3] = 5; //test3

            //// Student 2
            //grades[1, 0] = 0; //test1
            //grades[1, 1] = 10; //test2
            //grades[1, 2] = 5; //test3
            //grades[1, 3] = 7; //test3


            //int[,] grades2 =
            //{
            //    {5, 10, 8, 5 },
            //    {0, 10, 5 ,7 }
            //};

            //Console.WriteLine(grades2[0, 3]);

            //Console.WriteLine(grades[0, 1]);


            //// output:
            //// Student1: 5 10 8 5
            //// Student2: 0 10 5 7

            //for(int studentIndex = 0; studentIndex < grades.GetLength(0); studentIndex++)
            //{
            //    Console.WriteLine("Student " + studentIndex + " : " );

            //    for(int gradesIndex = 0; gradesIndex < grades.GetLength(1); gradesIndex++)
            //    {
            //        Console.WriteLine(grades[studentIndex, gradesIndex] + " ");
            //    }
            //}



            // Exercise:
            // Input: number of students (FE: 3)
            // Input: number of tests (FE: 2)

            // Result for student0 for test0 is = Input: 5;
            // Result for student0 for test1 is = Input: 10;

            // Result for student1 for test0 is = Input: 6;
            // Result for student1 for test1 is = Input: 4;

            // Result for student2 for test0 is = Input: 10;
            // Result for student2 for test1 is = Input: 4;

            // 2D array ALL DYNAMIC
            //int numberOfStudents = Convert.ToInt32(Console.ReadLine()); //3
            //int numberOfTests = Convert.ToInt32(Console.ReadLine()); //2

            //double[,] grades = new double[numberOfStudents, numberOfTests]; // [3,2]

            ///*
            // *   0     0 
            // *   0     0
            // *   0     0
            // */

            //// Input of data
            //for (int studentIndex = 0; studentIndex < grades.GetLength(0); studentIndex++)
            //{
            //    for (int testIndex = 0; testIndex < grades.GetLength(1); testIndex++)
            //    {
            //        Console.WriteLine($"Student {studentIndex} Test {testIndex}:");
            //        grades[studentIndex, testIndex] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //// output
            //// Student 0 : 7.5
            //// Student 1: 5
            //// Student 2: 7
            //for (int studentIndex = 0; studentIndex < grades.GetLength(0); studentIndex++)
            //{
            //    double studentAverage = 0;
            //    double studentGradeTotal = 0;

            //    for (int testIndex = 0; testIndex < grades.GetLength(1); testIndex++)
            //    {
            //        // loop over the test, ask for the data add it with the studentGradeTotal
            //        studentGradeTotal += grades[studentIndex, testIndex];

            //        // grades[0,0]
            //        // grades[0,1]

            //    }

            //    studentAverage = studentGradeTotal / numberOfTests;

            //    Console.WriteLine($"Student {studentIndex} has an average of {studentAverage}");
            //}

            //// Output
            //// test1 average is 7
            //// test2 average is 6
            //for (int testIndex = 0; testIndex < grades.GetLength(1); testIndex++)
            //{
            //    double testAverage = 0;
            //    double testTotal = 0;

            //    for (int studentIndex = 0; studentIndex < grades.GetLength(0); studentIndex++)
            //    {
            //        testTotal += grades[studentIndex, testIndex];
            //    }

            //    testAverage = testTotal / numberOfStudents;

            //    Console.WriteLine($"Test {testIndex} has an average of {testAverage}");
            //}


            // Jagged array
            //string[][] users = new string[3][];

            //// user 1: {"collin", "jozef"}
            //// user 2: {"himself"}
            //// user 3: {"collin", "jan", "maria", "henry"}

            //users[0] = new string[2] { "collin", "jozef" };

            //users[1] = new string[1] { "himself" };
            //users[2] = new string[4] { "collin", "jan", "maria", "henry" };

            //users[1][0] = "herself";

            //for (int userIndex = 0; userIndex < users.Length; userIndex++)
            //{
            //    Console.WriteLine("User " + userIndex + " has this friends:");
            //    for (int friendIndex =0; friendIndex < users[userIndex].Length; friendIndex++)
            //    {
            //        Console.WriteLine(users[userIndex][friendIndex]);
            //    }

            //}




            // How many users do you want to add?
            // Input: 2
            //
            // User 1, how many friends do you have?
            // Input: 2
            // What is the name of your friend 1?
            // Input: "Collin"
            // What is the name of your friend 2?
            // Input: "Tom"

            // User 2, how many friends do you have?
            // Input: 1
            // What is the name of your friend 1?
            // Input: "Collin"

            /*
                collin tom
                collin
            */

            int amountOfUsers = Convert.ToInt32(Console.ReadLine()); //2
            string[][] users = new string[amountOfUsers][];

            /*
             *  {}
             *  {}
             */

            for (int userIndex = 0; userIndex < users.Length; userIndex++)
            {
                // ask for many friends they have
                Console.WriteLine($"User {userIndex + 1}, how many friends do you have?");
                int amountOfFriends = Convert.ToInt32(Console.ReadLine()); // 2

                string[] friends = new string[amountOfFriends]; // { "", "" }

                // Fill the friends
                for (int friendIndex = 0; friendIndex < friends.Length; friendIndex++)
                {
                    Console.WriteLine($"What is the name of your friend {friendIndex + 1}?");
                    friends[friendIndex] = Console.ReadLine();
                }

                // Give the array of friends back at a specific user 
                users[userIndex] = friends;
            }

            // Output the stagged array
            for (int userIndex = 0; userIndex < users.Length; userIndex++)
            {
                Console.WriteLine($"User {userIndex + 1 } has following friends:");

                for (int friendIndex = 0; friendIndex < users[userIndex].Length; friendIndex++)
                {
                    Console.WriteLine(users[userIndex][friendIndex]);
                }

            }

        }
    }
}





















// Exercises


// Put them in a list hardcoded
// output them manually










// Exercise 8
// The split method: give me students with a space seperated
// Put them in a list
// output them with a while loop 


// Exercise 9
// The split method: give me them grades
// Put them in a list
// output them with a while loop


// Exercise 10
// The split method: give me them grades
// Put them in a list
// output them with a while loop 


// Exercise 11
// Sort grades given grades


// Exercise 13
// Give me the average of given grades


// Exercise 14
// Give me the median of given grades


// Exercise 15
// Give me the average of given grades but exclude the 0 scores


// Exercise 16
// 2D array explanation (students + grades )


// Exercise 17
// Fill in a 2d array (amount of students + amount of test)


// Exercise 18
// Fill in a 2d array (amount of students + amount of test)
// Give me back the average per student for grades


// Exercise 19 
// Fill in a 2d array (amount of students + amount of test)
// I want the best student (name and result!)


// Exercise 20 
// Database authentication
// harrypotter ihatevoldemort
// ronweasley ilovehermione
// hermione234 ROnNNn
// User need to feel in a username and password do check if it existi


// Exercise 21
// Jagged Arrays
// Selling bananas
// What is the best month?
// January: 240, 50, 80
// February: 50, 80
// March: 50, 80, 600
// April: 200, 100, 400
// May: 10
