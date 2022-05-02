using System;
using System.Collections.Generic;

namespace Lesson9
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // RECAP TIME
            // Variables (boolean, string, double, int, char)
            //string firstname = "Collin"; 
            //char favoriteCharacter = 'C'; 
            //double height = 1.94;
            //int age = 31;
            //bool isMarried = true;
            ////Console.WriteLine(isMarried.GetType());

            //// Comments (// and /* */)

            //// this is a comment - one line comments

            ///*
            // * Multiline
            // * Comments
            // */


            //// Mathematical Operators (+, *, -, %, /, ++, +=, --, -=)
            ////age = age + 10;
            ////age = age * 2;
            ////age = age / 2;
            ////age = age - 10;
            ////age = age % 2; // this will give you back the remainder of it

            ////age += 10;
            ////age++; // +1
            ////age += 1;
            ////age *= 2;
            ////age = age + 1;
            ////++age;


            //// Comparison Operators (<, >, <=, >=)
            ////Boolean isOlderThen30 = age > 30;
            ////Boolean isOlderOrEqualThen30 = age >= 30;
            ////Boolean isYoungerThen30 = age < 30;
            ////Boolean isYoungerOrEqualThen30 = age <= 30;




            //// Converting (Convert.ToInt32() or cast)
            ////int age2 = Convert.ToInt32(Console.ReadLine());
            ////double height2 = Convert.ToDouble(Console.ReadLine());





            //// Conditionals (if/else if/else statement, multiple conditions, switch, ..)
            //if (age > 18)
            //{
            //    Console.WriteLine("You can enter the party");
            //} else if (age < 16) {
            //    Console.WriteLine("You are way to young");
            //} else
            //{
            //    Console.WriteLine("You have to wait for 2 years");
            //}

            //// && -> and operato -> all the conditions need to be set to true
            //// || -> or operator -> only condition need to be set to true
            //// age = 70 -> enjoy life
            //Boolean isFemale = true;
            //Boolean isBetween18and67 = age > 18 && age < 67;

            //if (isBetween18and67 || isFemale || firstname == "Collin")
            //{
            //    Console.WriteLine("You have to work");
            //} else
            //{
            //    Console.WriteLine("Enjoy life");
            //}



            // TryParse
            //int age;

            //Boolean checkIfAgeIsString = int.TryParse(Console.ReadLine(), out age);

            //if (checkIfAgeIsString)
            //{
            //    Console.WriteLine("Good job the input was an int");
            //} else
            //{
            //    Console.WriteLine("Damn, you are dumb");
            //}






            // For loop
            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int index = 0; index <= 10; index++)
            //{
            //    int result = number * index;
            //    Console.WriteLine($"{index} x {number} = {result}");
            //}






            // While loop and do while loop

            // secretPassword = appletree
            //Console.WriteLine("Knock knock, give me the password");
            //string secretPassword = Console.ReadLine();

            //while (secretPassword != "appletree") // whenever this is true
            //{
            //    Console.WriteLine("Knock knock, give me the password");
            //    secretPassword = Console.ReadLine();
            //}

            //do
            //{
            //    Console.WriteLine("Knock knock, give me the password");
            //    secretPassword = Console.ReadLine();
            //} while (secretPassword != "appletree");







            // Files output -> StreamWriter stream = File.CreateText("file.txt");







            // Files input -> StreamReader stream = File.OpenText("file.txt"); (read by char, read it all, read line per line)







            // 1D array + looping through (for loop, foreach
            // a student has 3 grades 10, 12, 20
            //int[] grades = new int[3];
            //grades[0] = 10;
            //grades[1] = 12;
            //grades[2] = 20;

            //int amountOfGrades = grades.Length;

            //double average;
            //int totalPoints = 0;

            //for (int index = 0; index < amountOfGrades; index++)
            //{
            //    totalPoints += grades[index];
            //}

            //foreach(int grade in grades)
            //{
            //    totalPoints += grade;
            //}

            //average = totalPoints / amountOfGrades;
            //Console.WriteLine(average);







            // 2D array
            // 1d array = { 10, 12, 20 } 1 student 3 grades
            // 1 student = 10, 12, 20
            // 2 student = 8, 16, 20

            //int[,] grades = new int[2, 3];

            //grades[0, 0] = 10;
            //grades[0, 1] = 12;
            //grades[0, 2] = 20;

            //grades[1, 0] = 8;
            //grades[1, 1] = 16;
            //grades[1, 2] = 20;

            //int[,] grades2 = {
            //    {10, 12, 20 },
            //    {8, 16, 20 }
            //};

            // exercise average of every student
            //int amountOfStudents = grades.GetLength(0);
            //int amountOfColumns = grades.GetLength(1);

            //Console.WriteLine(amountOfStudents); // 2
            //Console.WriteLine(amountOfColumns); // 3

            //for (int studentIndex = 0; studentIndex < amountOfStudents; studentIndex++)
            //{
            //    double totalPointsStudent = 0;
            //    double average;

            //    for (int testIndex = 0; testIndex < amountOfColumns; testIndex++)
            //    {
            //        totalPointsStudent += grades[studentIndex, testIndex];
            //    }

            //    average = totalPointsStudent / amountOfColumns;

            //    Console.WriteLine($"Student {studentIndex + 1} the avg is {average}");
            //}


            // Jagged array
            // 1 student = 10, 12, 20
            // 2 student = 8, 16

            //int[][] grades = new int[2][];
            //grades[0] = new int[3];
            //grades[1] = new int[2];

            //// student 1
            //grades[0][0] = 10;
            //grades[0][1] = 12;
            //grades[0][2] = 20;

            //// student 2
            //grades[1][0] = 8;
            //grades[1][1] = 16;

            //int amountOfStudents = grades.Length;

            //for (int studentIndex = 0; studentIndex < amountOfStudents; studentIndex++)
            //{
            //    double average = 0;
            //    double totalPoints = 0;

            //    int amountOfTests = grades[studentIndex].Length;

            //    for (int testIndex = 0; testIndex < amountOfTests; testIndex++)
            //    {
            //        int grade = grades[studentIndex][testIndex];
            //        totalPoints += grade;
            //    }

            //    average = totalPoints / amountOfTests;

            //    Console.WriteLine(average);
            //}




            // Lists
            // student 1 = 12, 16, 20
            //List<int> grades = new List<int>();
            //List<int> grades2 = new List<int>() { 10, 20 };

            //grades.Add(12);
            //grades.Add(12);
            //grades.Add(16);
            //grades.Add(20);

            ////grades.Remove(12); //.Remove() -> will remove the first occurence
            ////grades.RemoveAt(1);

            //grades.AddRange(grades2);


            ////for(int gradeIndex = 0; gradeIndex < grades.Count; gradeIndex++)
            ////{
            ////    Console.WriteLine(grades[gradeIndex]);
            ////}

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}


            //List<string> guestlist = new List<string>() { "Collin", "Lisa" };

            //guestlist.AddRange("Mo,Jebus".Split(','));

            //string name = Console.ReadLine();

            //int indexOf = guestlist.IndexOf(name);
            //Console.WriteLine(indexOf);

            //if (guestlist.IndexOf(name) > -1)
            //{
            //    Console.WriteLine("You can enter");
            //} else
            //{
            //    Console.WriteLine("You are not on the list");
            //}


            // dictionairy key -> value
            // collin = 1.94
            // lisa = 1.40
            //Dictionary<string, double> heights = new Dictionary<string, double>();

            //heights.Add("collin", 1.94);
            //heights.Add("lisa", 1.40);


            //Console.WriteLine(heights.ContainsKey("collin"));

            //// o: collin is 1.94
            //// o: lisa is 1.40

            //foreach(var person in heights )
            //{
            //    Console.WriteLine(person.GetType());
            //    Console.WriteLine(person.Key);
            //    Console.WriteLine(person.Value);
            //}

            // Dictionaries

            // student Collin grades 10,12,14
            // student Lisa grades 8,5,2

            Dictionary<string, List<int>> gradebook = new Dictionary<string, List<int>>();

            // init the students with empty list
            gradebook.Add("collin", new List<int>());
            gradebook.Add("lisa", new List<int>());

            gradebook["collin"].Add(10);
            gradebook["collin"].Add(12);
            gradebook["collin"].Add(14);

            gradebook["lisa"].Add(8);
            gradebook["lisa"].Add(5);
            gradebook["lisa"].Add(2);


            // calculate the average per student
            foreach(var student in gradebook)
            {
                string studentName = student.Key;
                List<int> studentGrades = student.Value;

                double totalPointsPerStudent = 0;
                double averagePerStudent = 0;

                foreach (int grade in studentGrades)
                    totalPointsPerStudent += grade;

                averagePerStudent = totalPointsPerStudent / studentGrades.Count;

                Console.WriteLine($"{studentName} has an average of {averagePerStudent}");
            }








        }
    }
}
