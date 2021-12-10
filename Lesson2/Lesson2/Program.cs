using System;

namespace Lesson2 // Project itselve
{
    class MainClass // Class of this file
    {
        public static void Main(string[] args)
        {
            // First exersi the recap
            //// Declaration of variables
            //string firstName = "";  
            //string familyName = "";

            //// Ask the user for his firstname and store in firstname variable
            //Console.WriteLine("Give me your firstname:");
            //firstName = Console.ReadLine();

            //// Ask the user for his familyname and store in familyname variable
            //Console.WriteLine("Give me your familyname:");
            //familyName = Console.ReadLine();

            ////Put in 1 new variable with concatenation of firstname and familyName
            //string fullname = firstName + " " + familyName;

            //// Say Hello to mister Collin 
            //Console.WriteLine("Hello " + fullname + ", nice to meet you");
            //Console.WriteLine($"Hello {fullname}, nice to meet you");

            // byte 0 - 255, no decimals, no negatives
            // short: 2 bytes(-32768 to 32967)
            // int: 4bytes (-2,147483,648 to 2,147483,647)

            //double length = 200.5;
            //double width = 125.5;
            //double area = length * width;

            //Console.WriteLine(length);
            //Console.WriteLine(width);
            //Console.WriteLine(area);

            //char grade = 'B';
            //string myNameIs = "Elke";
            //Console.WriteLine(grade);

            //double length;
            //double width;
            //double area;

            //length = 200.5;
            //width = 2;
            //area = length * width;

            //Console.ReadLinee();

            // Hello
            // My Name is Collin
            // -----

            /*
              Collin 
            */


            //Console.Write("C");
            //Console.Write("O");
            //Console.Write("L");
            //Console.Write("L");
            //Console.Write("I");
            //Console.Write("N");

            //Console.WriteLine("Give me number 1 please:");
            //double number1 = Convert.ToDouble("5");
            //double number2 = 10.5;

            // ask a string number to the user
            //string stringNumber1 = Console.ReadLine();
            //number1 = Convert.ToDouble(stringNumber1);
            //number1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(number1);


            //double sum = number1 + number2;
            //double substraction = number1 - number2;
            //double multiply = number1 * number2;
            //double division = number1 / number2;
            //double remainder = number2 % number1;
            //double specialExpression = (number1 + number2) * 2;


            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Substraction: " + substraction);
            //Console.WriteLine("Multiply: " + multiply);
            //Console.WriteLine("Division: " + division);
            //Console.WriteLine("Remainder: " + remainder);
            //Console.WriteLine("Special expression: " + specialExpression);

            //// x = 100 - 50 * 2
            //Console.Write(100 - (50 * 2));

            //Console.WriteLine("Giver");
            //int input = Console.ReadLine();

            //Console.WriteLine(input);

            //Console.WriteLine("Give me the most beautiful name in the world:");
            //string givenWord = Console.ReadLine();

            //Console.WriteLine(givenWord == "collin");


            //int number1 = 5;
            //int number2 = 10;

            //Console.WriteLine(number1 == number2); // 5 is equal to 10? no -> false
            //Console.WriteLine(number1 != number2); // 5 is not equal to 10? yes -> true
            //Console.WriteLine(number1 < number2); // is 5 smaller then 10? yes -> true
            //Console.WriteLine(number1 > number2); // is 5 great then 10? no -> false
            //Console.WriteLine(number1 <= number2); // is 5 smaller then or the same as 10? yes -> true
            //Console.WriteLine(number1 >= number2); // is 5 great then or the same as 10? no -> false

            // 1k of sausages = 5EUROs
            //double costOfSausage = 5;

            //Console.WriteLine("Give me yah money:");
            //double receivedMoneys = Convert.ToDouble(Console.ReadLine());


            //Console.WriteLine(receivedMoneys < costOfSausage);
            //Console.WriteLine(receivedMoneys - costOfSausage);

            string input = Console.ReadLine();
            int number1 = Convert.ToInt32(input);
            Console.WriteLine(number1 / 2);
        }
    }
}
