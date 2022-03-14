using System;

namespace Lesson6_theory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Classroom 4 students: Collin, Youssef, Lisa, Anna

            // O: Student 1 is Collin
            // O: Student 2 is Youssef
            // O: Student 3 is Lisa
            // O: Student 4 is Anna

            // EXAMPLE ARRAY
            // int[] array = new int[5]
            // int[] array = { 1, 3, 8, 23, 99 }

            //string[] students = new string[4];

            //students[0] = "Collin";
            //students[1] = "Youssef";
            //students[2] = "Lisa";
            //students[3] = "Anna";

            //string[] students = { "Collin", "Youssef", "Lisa", "Anna" };

            //Console.WriteLine("Amount of students are " + students.Length);

            //int amountOfStudents = students.Length; // 4

            //for (int studentIndex = 0; studentIndex < amountOfStudents; studentIndex++)
            //{
            //    Console.WriteLine($"Student {studentIndex + 1 } is {students[studentIndex]} ");
            //}

            //foreach (string student in students)
            //{
            //    Console.WriteLine("Student is " + student);
            //}


            // O: How many students do you have?
            // I: 2
            // O: What is the name of student 1?
            // I: Collin
            // O: What is the name of student 2?
            // I: Lisa
            // O: The students are: collin lisa

            //// Ask how many students
            //Console.WriteLine("How many students do you have?");
            //int amountOfStudents = Convert.ToInt16(Console.ReadLine()); // 2

            //// Create a new array with the amount of students
            //string[] students = new string[amountOfStudents];

            //// populate the array
            //for (int index = 0; index < students.Length; index++)
            //{
            //    Console.WriteLine($"What is the name of student {index + 1}?");
            //    students[index] = Console.ReadLine();
            //}

            //// students = { "Collin", "Lisa" }
            //Console.WriteLine("The students are:");

            //foreach(string student in students)
            //{
            //    Console.Write(student + " ");
            //}

            // MY AWESOME MY COMPANY
            // Bought a computer 500
            // Sold a website 1500
            // Sold another website 2000
            // Buy a car 2000
            // -500 + 1500 + 2000
            //int[] accountancy = { -500, 1500, 2000, -2000};

            //int result = 0;

            //foreach (int money in accountancy )
            //{
            //    result += money;
            //}

            //Console.WriteLine(result);

            // Give me back the average of 16, 20, 10
            //double[] grades = new double[3];
            //grades[0] = 16;
            //grades[1] = 20;
            //grades[2] = 10;

            //double totalPoints = 0;

            //foreach(double grade in grades)
            //{
            //    totalPoints += grade;
            //}

            //double average = totalPoints / grades.Length;
            //Console.WriteLine(average);






            // JAGED ARRAYS
            //string input = Console.ReadLine(); // lisa,youssef,collin
            //string[] students = input.Split(',');
            //Array.Sort(students);
            //Console.WriteLine(string.Join(" ",students));

            //int[,] gradebooks = new int[2, 3];
            //int[,] gradebooks2 ={
            //    { 10, 12, 8 },
            //    { 14, 18 ,8 }
            //};

            //// student 1
            //gradebooks[0,0] = 10;
            //gradebooks[0,1] = 12;
            //gradebooks[0,2] = 8;

            //// student 2
            //gradebooks[1, 0] = 14;
            //gradebooks[1, 1] = 18;
            //gradebooks[1, 2] = 8;

            //int amountOfStudents = gradebooks.GetLength(0); // .GetLength(0) will give you back amount of rows
            //int amountOfTests = gradebooks.GetLength(1); // .GetLength(1) will give you back amount of columns

            //Console.WriteLine(amountOfStudents);
            //Console.WriteLine(amountOfTests);

            //for (int studentIndex = 0; studentIndex < amountOfStudents; studentIndex++)
            //{
            //    Console.WriteLine($"Student {studentIndex + 1 }");

            //    for (int testIndex = 0; testIndex < amountOfTests; testIndex++ )
            //    {
            //        int grade = gradebooks[studentIndex, testIndex];
            //        Console.WriteLine($"Test {testIndex + 1 }: {grade}");
            //    }
            //}

            int[][] gradebook = new int[3][];

            // Student 1
            gradebook[0] = new int[3];
            gradebook[0][0] = 10;
            gradebook[0][1] = 12;
            gradebook[0][2] = 8;

            // Student 2
            gradebook[1] = new int[3];
            gradebook[1][0] = 14;
            gradebook[1][1] = 18;
            gradebook[1][2] = 8;

            // Student 3
            gradebook[2] = new int[2];
            gradebook[2][0] = 10;
            gradebook[2][1] = 20;

            // output
            int amountOfRows = gradebook.Length;
            
            for (int studentIndex = 0; studentIndex < amountOfRows; studentIndex++)
            {
                Console.WriteLine($"Student {studentIndex + 1}: ");

                int amountOfColumns = gradebook[studentIndex].Length;
                int studentTotalGrades = 0;

                for (int testIndex = 0; testIndex < amountOfColumns; testIndex++)
                {
                    int grade = gradebook[studentIndex][testIndex];
                    Console.WriteLine($"Test {testIndex + 1} : {grade}");

                    studentTotalGrades += grade;
                }

                double studentAverage = studentTotalGrades / amountOfColumns;
                Console.WriteLine($"The avg for student {studentIndex + 1 }: {studentAverage}"); 
            }

        }
    }
}
