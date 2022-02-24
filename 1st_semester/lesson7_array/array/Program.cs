using System;

namespace array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Basic stuff
            //string[] characters = new string[3]; // {"", "", ""}
            //string[] charactersLordOfTheRings = { "Frodo", "Gollum", "Gandalf" };
            //characters[0] = "Harry Potter"; // {"Harry Potter", "", ""}
            //characters[1] = "Ron Weasly"; // {"Harry Potter", "Ron Weasly", ""}
            //characters[2] = "Hermione Granger"; // {"Harry Potter", "Ron Weasly", "Hermione Granger"}

            //Console.WriteLine(characters[0]);
            //Console.WriteLine(characters[1]);
            //Console.WriteLine(characters[2]);
            //Console.WriteLine(characters.Length);






            // Ask amount of students (FE 2)
            // Give me the name of student1: (FE "Jebus")
            // Give me the name of student2: (FE "Ivan The Late")
            // Print them out
            // Student 1 is Jebus
            // Student 2 is Ivan The Late
            //int amountOfStudents = Convert.ToInt16(Console.ReadLine()); // amountOfStudents = 2;
            //string[] students = new string[amountOfStudents]; // {"", ""}

            //// Fill it in 
            //for(int index = 0; index < students.Length; index++)
            //{
            //    Console.WriteLine($"Give me the name of student {index + 1}");
            //    students[index] = Console.ReadLine();
            //}

            //// Output the list
            //for(int index = 0; index < students.Length; index++)
            //{
            //    string student = students[index];
            //    Console.WriteLine($"Student {index + 1} is {student}");
            //}




            // Ask for the amount of studens (FE: 3) -> ODD NUMBER
            // What is the result for student 1? (FE: 20)
            // What is the result for student 2? (FE: 5)
            // What is the result for student 3? (FE: 2)
            // FIRST: The average is 9 (EASY PEASY)
            // LATER ON: The median is 5 (NOT SO EASY PEASY) -> YOU SORT THEM TAKE THE MIDDLE ONE

            // Ask for the amount of studens (FE: 5) -> ODD NUMBER
            // What is the result for student 1? (FE: 10)
            // What is the result for student 2? (FE: 12)
            // What is the result for student 3? (FE: 11)
            // What is the result for student 4? (FE: 3)
            // What is the result for student 5? (FE: 4)
            // FIRST: The average is 8 (EASY PEASY)
            // LATER ON: The median is 10 (NOT SO EASY PEASY) -> (3, 4, 10, 11, 12)

            //int amountOfStudents = Convert.ToInt16(Console.ReadLine());
            //int[] grades = new int[amountOfStudents];

            //// Fill in the array
            //for (int index = 0; index< grades.Length; index++)
            //{
            //    Console.WriteLine($"What is the result for student {index + 1}?");
            //    grades[index] = Convert.ToInt16(Console.ReadLine());
            //}

            //// Calculate the average
            //// 20 + 5 + 2 = 27 / 3 = 9
            //int sumOfGrades = 0; //sum of grades

            //foreach (int grade in grades) //grade = 20, grade = 5, grade = 2
            //{
            //    sumOfGrades += grade; 
            //}

            //double average = sumOfGrades / grades.Length;

            //Console.WriteLine($"The average is {average}");

            //// Calculate the median
            //Array.Sort(grades);

            //int middleItem = grades.Length / 2; // 5 / 2 = 2
            //int median = grades[middleItem];
            //Console.WriteLine($"The median is {median}");



            // 2D array
            //Console.WriteLine("Helleeeuw, how many students do you have?");
            //int amountOfStudents = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("Helleeeuw, how many grades do you have?");
            //int amountOfGrades = Convert.ToInt16(Console.ReadLine());
            //int[,] gradebook = new int[amountOfStudents, amountOfGrades];


            //// Fill the 2D array
            //// [
            ////   [4,5,10] //student1
            ////   [5,10,8] //student2
            //// ]
            //for (int student = 0; student < gradebook.GetLength(0); student++)
            //{
            //    Console.WriteLine($"Can you give me the results for students {student + 1}");

            //    for (int test = 0; test < gradebook.GetLength(1); test++)
            //    {
            //        gradebook[student, test] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}


            //// Output the grades for a student
            //// Student1 results are:
            //// 4
            //// 5
            //// 10
            //// Student2 results are
            //// 5
            //// 10
            //// 8
            //for(int student = 0; student < gradebook.GetLength(0); student++) {
            //    Console.WriteLine($"Student {student + 1} results are:");

            //    for (int test = 0; test < gradebook.GetLength(1); test++)
            //    {
            //        Console.WriteLine(gradebook[student, test]);
            //    }
            //}


            //// Output of average of student
            //// Student1 has an average of 6.33333...
            //// Student2 has an average of 7.66666..
            //for (int student = 0; student < gradebook.GetLength(0); student++)
            //{
            //    double sumOfGrades = 0;

            //    for (int test = 0; test < gradebook.GetLength(1); test++)
            //    {
            //        sumOfGrades += gradebook[student, test];
            //    }

            //    double average = sumOfGrades / gradebook.GetLength(1); // 19 / 3 = 6.33333
            //    Console.WriteLine($"Student {student + 1} has an average of {average}");
            //}






            // STAGED ARRAYS
            // X X X
            // X X X
            // X X X

            // 5 10 6
            // 6 6

            Console.WriteLine("How many students do you have?");
            int amountOfStudents = Convert.ToInt16(Console.ReadLine()); // FE 2
            int[][] gradebook = new int[amountOfStudents][];

            // student1
            for (int studentIndex = 0; studentIndex < gradebook.Length; studentIndex ++)
            {
                // Create a new array for a student with the amount of grades 
                Console.WriteLine($"Hello for student {studentIndex + 1}, how many grades do they have?");
                int amountOfGrades = Convert.ToInt16(Console.ReadLine()); // FE 3
                gradebook[studentIndex] = new int[amountOfGrades];

                // Fill it in already
                Console.WriteLine("Give me the results for this student");

                for (int gradeIndex = 0; gradeIndex < amountOfGrades; gradeIndex++)
                {
                    Console.WriteLine($"Give me the result of student {studentIndex + 1} for test {gradeIndex + 1}");
                    gradebook[studentIndex][gradeIndex] = Convert.ToInt16(Console.ReadLine());
                }
            }

            //// Output the grades for a student
            //// Student1 results are:
            //// 5
            //// 10
            //// 6
            //// Student2 results are
            //// 6
            //// 6
            for (int studentIndex = 0; studentIndex < gradebook.GetLength(0); studentIndex++)
            {
                Console.WriteLine($"Student {studentIndex + 1} results are:");
                int[] gradesOfStudent = gradebook[studentIndex];
                int amountOfGrades = gradesOfStudent.Length;

                for (int gradeIndex = 0; gradeIndex < amountOfGrades; gradeIndex++)
                {
                    Console.WriteLine(gradesOfStudent[gradeIndex]);
                }
            }


        }
    }
}
