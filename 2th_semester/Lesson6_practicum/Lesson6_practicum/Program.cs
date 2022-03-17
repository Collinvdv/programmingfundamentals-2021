using System;
using System.IO;

namespace Lesson6_practicum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // Introduction
            //int[] tests = new int[3]; // { 0, 0, 0 }
            //int[] tests2 = { 5, 10, 15 };
            //tests[0] = 5;
            //tests[1] = 10;
            //tests[2] = 15;

            //Console.WriteLine(tests.Length); // 3

            //Console.WriteLine(tests[0]); //5
            //Console.WriteLine(tests[1]); //10
            //Console.WriteLine(tests[2]); //15

            //for (int index = 0; index < tests.Length; index++)
            //{
            //    Console.WriteLine(tests[index]);
            //}

            //foreach(int test in tests)
            //{
            //    Console.WriteLine(test);
            //}





            //
            // O: 
            // I: 3
            // O: Student1 result is:
            // I: 10
            // O: Student2 result is:
            // I: 14
            // O: Student3 result is:
            // I: 18
            // O: Average is 14
            //




            //
            // Hardcoded grades = 10, 14, 18
            // O: Average is 14
            //


            //
            // O: How many students for this grade?
            // I: 3
            // O: Student1 result is:
            // I: 10
            // O: Student2 result is:
            // I: 14
            // O: Student3 result is:
            // I: 18
            // O: Average is 14
            // O: The median is 14
            //


            //Console.WriteLine("How many students for this test?");
            //int amountOfStudents = Convert.ToInt16(Console.ReadLine());
            //int[] grades = new int[amountOfStudents]; // { 0, 0, 0 }

            //// Populate the array
            //for (int index = 0; index < grades.Length; index++)
            //{
            //    Console.WriteLine($"Student {index + 1} result is:");
            //    grades[index] = Convert.ToInt16(Console.ReadLine());
            //}

            //// Calculate the average
            //int totalPoints = 0;

            //foreach (int grade in grades)
            //{
            //    totalPoints += grade;
            //}

            //double average = totalPoints / grades.Length;

            //Console.WriteLine($"Average is {average}");


            //// Calculate the median
            //Array.Sort(grades); // this will sort the array

            //if (grades.Length % 2 == 0)
            //{
            //    // even
            //    int middle = grades.Length / 2; // 3
            //    double median = (grades[middle - 1] + grades[middle]) / 2;
            //    Console.WriteLine($"The median is {median}");
            //} else
            //{
            //    // odd
            //    int middle = Convert.ToInt16(Math.Floor(Convert.ToDouble(grades.Length) / 2));
            //    int median = grades[middle];
            //    Console.WriteLine($"The median is {median}");
            //}


            //int[,] grades = new int[2, 3];

            //// student 1
            //grades[0, 0] = 10; // first test
            //grades[0, 1] = 14; // second test
            //grades[0, 2] = 20; // thirth test


            //// student 2
            //grades[1, 0] = 16; // first test
            //grades[1, 1] = 14; // second test
            //grades[1, 2] = 12; // thirth test


            //for(int studentIndex = 0; studentIndex < grades.GetLength(0); studentIndex++)
            //{
            //    for (int gradeIndex = 0; gradeIndex < grades.GetLength(1); gradeIndex++)
            //    {
            //        Console.WriteLine($"Student {studentIndex + 1} Test {gradeIndex + 1}: " + grades[studentIndex, gradeIndex]);;
            //    }
            //}


            //
            // Accountancy
            // Quarter1: 1500 -1000 -300
            // Quarter2: 1700 -800 -300
            // Quarter3: 5000 -1000 300
            // Quarter4: 1500 1000 -300
            //
            // O: Result quarter 1 is 200
            // O: Result quarter 2 is 600
            // O: Result quarter 3 is 4300
            // O: Result quarter 4 is 2200
            // O: Total result is 7300
            //
            //int[,] accountancy = {
            //    { 1500, -1000, -300 }, //quarter 1
            //    { 1700, -800, -300 }, //quarter 2
            //    { 5000, -1000, 300 }, //quarter 3
            //    { 1500, 1000, -300 }, //quarter 4
            //};

            //// Calculate results per quarter
            //int yearResult = 0;

            //for (int quarterIndex = 0; quarterIndex < accountancy.GetLength(0); quarterIndex++)
            //{
            //    int quarterResult = 0;

            //    for (int monthIndex = 0; monthIndex < accountancy.GetLength(1); monthIndex++)
            //    {
            //        quarterResult += accountancy[quarterIndex, monthIndex];
            //    }
            //    Console.WriteLine($"Result quarter {quarterIndex + 1} is: {quarterResult}");

            //    yearResult += quarterResult;
            //}


            //Console.WriteLine($"Total result is {yearResult}");




            //
            // Best day of the week
            // Monday = 5.5
            // Tuesday = 10
            // Wednesday = 7
            // Thursday = 12
            // Friday = 15
            // Saturday = 22
            // Sunday = 10
            //
            // O: Hotest day of the week is Saturday with 22
            // O: Coldest day of the week is Monday with 5.5
            //

            //double[] temperatures = { 5.5, 10, 7, 12, 15, 22, 10 };
            //string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //double coldestTemperature = 1000;
            //double hotestTemperature = -1000;

            //int coldestTemperatureIndex = 0;
            //int hotestTemperatureIndex = 0;

            //for (int index = 0; index < temperatures.Length; index++)
            //{
            //    double temperature = temperatures[index];

            //    if (temperature < coldestTemperature)
            //    {
            //        coldestTemperature = temperature;
            //        coldestTemperatureIndex = index;
            //    }

            //    if (temperature > hotestTemperature)
            //    {
            //        hotestTemperature = temperature;
            //        hotestTemperatureIndex = index;
            //    }
            //}

            //Console.WriteLine($"Coldest day of the week is {weekDays[coldestTemperatureIndex]} with {coldestTemperature}");
            //Console.WriteLine($"Hotest day of the week is {weekDays[hotestTemperatureIndex]} with {hotestTemperature}");







            // Accountancy part 2
            // Read files 2020.txt, 2021.txt and 2022.txt
            // Give me back the final result
            // O: 5900


            string[] files = { "2020.txt", "2021.txt", "2022.txt" };


            int result = 0;
            foreach (string file in files)
            {
                StreamReader readFile = new StreamReader(file);

                while(!readFile.EndOfStream)
                {
                    int lineAmount = Convert.ToInt16(readFile.ReadLine());
                    
                    result += lineAmount;
                }

                readFile.Close();
            }

            Console.WriteLine(result);

        }
    }
}














































//
// O: How many students do you have??
// I: 3
// O: How many test do you have??
// I: 2
// O: Student1 Test1 result is:
// I: 10
// O: Student1 Test2 result is:
// I: 12
// O: Student2 Test1 result is:
// I: 10
// O: Student2 Test2 result is:
// I: 18
// O: Student3 Test1 result is:
// I: 10
// O: Student3 Test2 result is:
// I: 11

// O: Student 1 Average is 11
// O: Student 2 Average is 14
// O: Student 3 Average is 10.5

// O: Test 1 Average is 10
// O: Test 2 Average is 13.66667
//











