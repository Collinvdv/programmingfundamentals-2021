using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Lesson5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Exercice 1

            /*
             * 
             * If statement  
             * -> favorite fruit 
             * 
             * if orange then say MMMHHHHH
             * if apple then  say NICEEE 
             * if none of above i don't recognice this fruit
             * 
             */
            //string fruit = Console.ReadLine();

            //if (fruit == "orange")
            //{
            //    Console.WriteLine("MMMHHHHH");
            //} else if (fruit == "apple")
            //{
            //    Console.WriteLine("NICEEE");
            //} else
            //{
            //    Console.WriteLine("i don't recognise this fruit");
            //}

            /*
            * 
            * Switch statement  
            * -> favorite fruit 
            * 
            * if orange say MMMHHHHH
            * if apple say NICEEE
            * if none of above i don't recognice this fruit
            * 
            */
            //string fruit = Console.ReadLine();

            //switch (fruit)
            //{
            //    case "orange":
            //        Console.WriteLine("MMMHHHHH");
            //        break;
            //    case "apple":
            //        Console.WriteLine("NICEEE");
            //        break;
            //    default:
            //        Console.WriteLine("i don't recognice this fruit");
            //        break;
            //}

            /*
            *
            * Multiplication table
            * Input a number (FE: 4)
            * Output 
            * 4 * 0 = 0
            * 4 * 1 = 4
            * 4 * 2 = 8
            * ...
            * 4 * 10 = 40
            */


            //for (int x = 0; x <= maximumNumber; x++) //x = x + 1;
            //{
            //    int result = x * number;
            //    Console.WriteLine($"{number} * {x} = {result}");
            //}

            //int number = Convert.ToInt32(Console.ReadLine());
            //int maximumNumber = 10;
            //int step = 11;

            //while (step <= maximumNumber) // expression should be true to execute this code
            //{
            //    // when condition is true it will run this code
            //    int result = step * number;
            //    Console.WriteLine($"{number} * {step} = {result}");

            //    step++;
            //}

            //do
            //{
            //    int result = step * number;
            //    Console.WriteLine($"{number} * {step} = {result}");

            //    step++;
            //} while (step <= maximumNumber);




            /*
             * The user needs to give me 2 numbers (101 - 300) 
             * If want to see which numbers are dividable by 3
             * 
             * When startnumber is bigger the end number, user has to input them again
             * 
             * While the startnumber is bigger or equal then the end nummer, ask the input again otherwise 
             * you can proceed
             */

            //int startNumber = Convert.ToInt32(Console.ReadLine()); //400
            //int endNumber = Convert.ToInt32(Console.ReadLine()); // 300

            // check whether the start number is smaller the end number
            //while (startNumber >= endNumber)
            //{
            //    Console.WriteLine("Startnumber is bigger then the end number can you input it again");
            //    startNumber = Convert.ToInt32(Console.ReadLine()); //400
            //    endNumber = Convert.ToInt32(Console.ReadLine()); // 300
            //}  

            //for (int step = startNumber; step <= endNumber; step++ )
            //{
            //    int remainder = step % 3;

            //    if (remainder == 0)
            //    {
            //        Console.WriteLine(step);
            //    }
            //}



            /*
             * 
             * FizzBuzz from 1 -> 15
             * 
             * If divided by 3 = Fizz
             * If divided by 5 = Buzz
             * If divided by 5 and by 3 = FizzBuzz
             * 
             * Output:
             * 1
             * 2
             * Fizz
             * 4
             * Buzz
             * Fizz
             * 7
             * 8
             * Fizz
             * Buzz
             * 11
             * Fizz
             * 13
             * 14
             * FizzBuzz
             */
            //for (int step = 1; step <= 15; step++)
            //{
            //    if (step % 3 == 0 && step % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    } else if (step % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (step % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    } else
            //    {
            //        Console.WriteLine(step);
            //    }
            //}



            /*
             * 
             * Stalking butcher 
             * 
             * KG of sausages = 5
             * Visitor has to give money 
             * 
             * If they 5 euro everything is fine
             * If they give more money we give money back
             * If they not gave enough money -> we ask it again
             * 
             * Input 5
             * Output Here are the sausages
             * 
             * Input 6
             * Output Here are the sausages, 1 euro back to you
             * 
             * Input 4
             * Ouput Give me more money this is not enough! 
             * Input 5 
             * Ouput Now it is enough, here are the sausages
             * 
             * Input 4
             * Ouput Give me more money this is not enough! 
             * Input 6
             * Ouput Now it is enough, here are the sausages, 1 euro back to you
             */
            double priceOfSausages = 5;
            double receivedMoney = Convert.ToDouble(Console.ReadLine());
            Boolean isFraud = false;

            // Check if they are a scammer
            while (receivedMoney < priceOfSausages)
            {
                Console.WriteLine("Give me more money this is not enough!");

                receivedMoney = Convert.ToDouble(Console.ReadLine());

                isFraud = true;
            }

            // Tell them they are a scammer
            if (isFraud)
            {
                Console.WriteLine("Now it is enough, scammer!");
            }

            // give them the back the sausages AND change
            if (receivedMoney == priceOfSausages)
            {    
                Console.WriteLine("Here are the sausages");
            } else
            {
                double change = receivedMoney - priceOfSausages;
                Console.WriteLine($"Here are the sausages, {change} euro back to you");
            }

        }
    }
}













