using System;

namespace lesson2_practica
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // hello world -> codegrade test
            //Read the name and surname of a person and say 'Hello' to them!

            //Test case examples
            // I: Collin
            // I: Van der Vorst
            // O: Hello Collin Van der Vorst!

            // I: Jan
            // I: Janssens
            // O: Hello Jan Janssens!

            //string firstname = Console.ReadLine();
            //string familyname = Console.ReadLine();

            //// Console.WriteLine("Hello " + firstname + " " + familyname + "!");
            //Console.WriteLine($"Hello {firstname} {familyname}!");






            // O: Give me 2 numbers:
            // I: 5
            // I: 10
            // O: 5 + 10 = 15
            // O: 5 - 10 = -5
            // O: 5 * 10 = 50
            // O: 5 / 10 = 0.5

            //Console.WriteLine("Give me 2 numbers:");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //double number2 = Convert.ToDouble(Console.ReadLine());

            //double sum = number1 + number2;
            //double min = number1 - number2;
            //double multiply = number1 * number2;
            //double division = number1 / number2;

            //// Console.WriteLine(number1 + " + " + number2 + " = " + sum);
            //Console.WriteLine($"{number1} + {number2} = {sum}");
            //Console.WriteLine($"{number1} - {number2} = {min}");
            //Console.WriteLine($"{number1} * {number2} = {multiply}");
            //Console.WriteLine($"{number1} / {number2} = {division}");






            // O: Which year are you born in?
            // I: 1991
            // O: This year you will turn 31 years
            //Console.WriteLine("Which year are you born in?");
            //int birthyear = Convert.ToInt16(Console.ReadLine());
            //int years = 2022 - birthyear; // 31
            //Console.WriteLine($"This year you will turn {years} years");






            // O: ASK 4 numbers and give back the average
            // I: 10
            // I: 15.5
            // I: 10
            // I: 15.5
            // O: average is: 12.75

            //Console.WriteLine("ASK 4 numbers and give back the average");
            //double number1 = Convert.ToDouble(Console.ReadLine());
            //double number2 = Convert.ToDouble(Console.ReadLine());
            //double number3 = Convert.ToDouble(Console.ReadLine());
            //double number4 = Convert.ToDouble(Console.ReadLine());
            //double average = (number1 + number2 + number3 + number4) / 4;

            //Console.WriteLine($"average is: {average}");







            // O: Welcome to the butcher
            // O: Price of sausages is 4.5euro per kg
            // O: How much kg do you want?
            // I: 3
            // O: That will be 13.5euro, please. Can you give me money?
            // I: 15
            // O: You will get 1.5euro back

            //double pricePerKg = 4.5;
            //Console.WriteLine("Welcome to the butcher");
            //Console.WriteLine($"Price of sausages is {pricePerKg}euro per kg");
            //Console.WriteLine("How much kg do you want?");
            //double amountOfKg = Convert.ToDouble(Console.ReadLine());

            //// Calculate total price
            //double totalPrice = amountOfKg * pricePerKg;
            //Console.WriteLine($"That will be {totalPrice}euro, please. Can you give me money?");

            //// Give back the money
            //double money = Convert.ToDouble(Console.ReadLine());
            //double change =  money - totalPrice;
            //Console.WriteLine($"You will get {change}euro back");






            // O: What is your name?
            // I: Collin
            // O: What is the name of your father??
            // I: Marc
            // O: What is the name of your mother?
            // I: Karine
            // O: Collin is the child of Marc and Karine
            Console.WriteLine("What is your name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is the name of your father?");
            string fathername = Console.ReadLine();

            Console.WriteLine("What is the name of your mother");
            string mothername = Console.ReadLine();

            Console.WriteLine($"{firstname} is the child of {fathername} and {mothername}");


            // O: Calculation of a square
            // O: What is the height of a square?
            // I: 5
            // O: What is the width of a square?
            // I: 7
            // O: The area of a this square is 35
            Console.WriteLine("What is the height of a square?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the width of a square?");
            double width = Convert.ToDouble(Console.ReadLine());
            double area = height * width;
            Console.WriteLine($"The area of a this square is {area}");

        }
    }
}















































