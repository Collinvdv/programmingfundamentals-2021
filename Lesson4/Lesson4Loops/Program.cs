using System;

namespace Lesson4Loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // First parameter: Added a step variable and initiliated with 1, which is my starting point
            // Counting from 1 to 20
            //for (int step = 1; step <= 20; step++)
            //{
            //    Console.WriteLine(step);
            //}

            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            // Counting only the odd numbers
            //for (int step = 1; step <= 20; step+=2)
            //{
            //    Console.WriteLine(step);
            //}


            // Count from 10 till 1
            //for (int index = 10; index > 0; index--)
            //{
            //    Console.WriteLine(index);
            //}

            // Count from 44 to 55
            // Output:
            // 44
            // 45
            // 46
            // 47
            // ..
            // 55
            //for (int number = 44; number <= 55; number++)
            //{
            //    Console.WriteLine(number);
            //}

            // Output:
            // 0
            // 10
            // 20
            // 30
            // 40
            // 50
            // ...
            // 100
            //for (int number = 0; number >= 0; number+=10)
            //{
            //    Console.WriteLine(number);
            //}


            // Input: a number (FE: 5);
            // Output 1:
            // 5 * 0 = 0
            // 5 * 1 = 5;
            // 5 * 2 = 10;
            // ...
            // 5 * 10 = 50;

            // Input a number (FE: 2)
            // Output 2:
            // 2 * 0 = 0
            // 2 * 1 = 2;
            // 2 * 2 = 4;
            // ...
            // 2 * 10 = 20;


            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(number * 0);
            //Console.WriteLine(number * 1);
            //Console.WriteLine(number * 2);

            //for (int step = 0; step <= 100; step++)
            //{
            //    int result = step * number;
            //    string output = $"{number} * {step} = {result}";

            //    Console.WriteLine(output);
            //}


            // Exercise starts
            // input: number (5)
            // output:
            // *
            // **
            // ***
            // ****
            // *****

            // input: number (7)
            // output:
            // * (1 star on row 1)
            // ** (2 stars on row 2)
            // *** (3 stars on row 3)
            // ****
            // *****
            // ******
            // *******

            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int row = 1; row <= number; row++)
            //{
            //    string stars = "";

            //    // row 1: 
            //    for (int column = 1; column <= row; column++)
            //    {
            //        stars = stars + "*";
            //    }
            //    Console.WriteLine(stars);
            //}

            // input: number (5)
            // output:
            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4
            // 1 2 3 4 5 

            // input: number (7)
            // output:
            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4
            // 1 2 3 4 5
            // 1 2 3 4 5 6
            // 1 2 3 4 5 6 7

            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int row = 1; row <= number; row++)
            //{
            //    string output = "";

            //    for (int x = 1; x <= row; x++)
            //    {
            //        output = output + $"{x} ";
            //    }

            //    Console.WriteLine(output);
            //}

            // Exponential calculation
            // Input: 5;
            // output
            // 5 (5 to the power of 1 OR 5)
            // 25 (5 to the power of 2 OR 5 * 5)
            // 125 (5 to the power of 3 OR 5 * 5 * 5)
            // 625
            // 3125
            // 15625
            // 78125
            // 390625
            // 1953125
            // 9765625

            // Easy solution
            //double input = Convert.ToDouble(Console.ReadLine()); //fe 5
            //double result = 1;

            //for(int i = 1; i<=10; i++)
            //{
            //    result = result * input;

            //    Console.WriteLine(result);
            //}

            // Loop in loop solution
            // 5
            // 5 * 5
            // 5 * 5 * 5
            // 5 * 5 * 5 * 5
            //double input = Convert.ToDouble(Console.ReadLine()); //fe 5

            //for (int i = 1; i <=10; i++)
            //{
            //    double result = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        result = result * input;
            //    }
            //    Console.WriteLine(result);
            //}


            // Super easy solution with a bit of google
            //double number = Convert.ToDouble(Console.ReadLine()); //fe 5

            //for (int power = 1; power <= 10; power++)
            //{
            //    Console.WriteLine(Math.Pow(number, power));
            //}



            // Authentication layer
            // Password, more then 3 attempts the computer will exit the loop
            // While the password is not loops123 and the attempts not exceeding 3 continue asking
            // Input: password (P:loops123)
            //string password = Console.ReadLine();
            //int attempts = 0;

            // collin != "loops123" -> true
            // 1 < 3 

            // collin != "loops123" -> true
            // 2 < 3 -> true

            //while (password != "loops123" && attempts < 3)
            //{
            //    attempts++;

            //    Console.WriteLine($"U already tried for {attempts} times");
            //    Console.WriteLine("Your password is not correct");

            //    password = Console.ReadLine();
            //}

            // Tomorrowland bouncer guy
            //int age = Convert.ToInt32(Console.ReadLine());

            //while (age < 18)
            //{
            //    Console.WriteLine("R u sure? If you tell me that you are older then 18 then you can enter");
            //    age = Convert.ToInt32(Console.ReadLine());
            //}


            // Exponential numbers
            // input a number: fe (5)
            // whenever the exponential number is smaller then 1,000,000 then it will show it,
            // if it is bigger then it will stop the loop
            // Math.Pow(number, power)

            //double baseNumber = Convert.ToDouble(Console.ReadLine());
            //double power = 0;
            //double total = 1; 

            //while (total < 1000000)
            //{
            //    Console.WriteLine(total); // 1

            //    power++;

            //    total = Math.Pow(baseNumber, power);
            //}


            //int age = Convert.ToInt32(Console.ReadLine());

            //while (age < 18)
            //{
            //    Console.WriteLine("This line will be executed when the condition is valid")
            //    Console.WriteLine("U are very young, give me your real age");

            //    age = Convert.ToInt32(Console.ReadLine());
            //}

            //do
            //{
            //    Console.WriteLine("This line always will be excuted 1 time");
            //} while (age < 18);



            for (int x = 1; x <= 10; x++)
            {
                if (x%2 == 0 )
                {
                    Console.WriteLine(x);
                }
            }


            //int counter = 1;

            //while (counter<=10)
            //{
            //    Console.WriteLine(counter);

            //    counter++;
            //}

            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= 10);


            //while (age < 18)
            //{
            //    Console.WriteLine("Welcome");
            //}




        }
    }
}














//double baseNumber = 5;
//double total = baseNumber;
//double power = 0;

//while (total < 1000000)
//{
//    Console.WriteLine(total);
//    power++;
//    total = Math.Pow(baseNumber, power);
//}



/*
 * 
 * Count from 1->5 
 * 
 */

/*
 * 
 * Count from 5->1 
 * 
 */

/*
 * 
 * Create Multiplication table, ask for a number then multiplication from 0->10
 * 
 */

/*
 * 
 * Give me them even numbers from 0 - 10
 * 
 */

/*
 * 
 * Exponential graph 
 * 
 */

/*
 * 
 * Create Multiplication table
 * 
 */

/*
 * 
 * Assignment: Show me a * 
 * 
 */