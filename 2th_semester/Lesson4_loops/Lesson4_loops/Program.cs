using System;

namespace Lesson4_loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Booze game!");

            //// Ask the age
            //int age = Convert.ToInt16(Console.ReadLine());

            //// younger then 16 -> you can not drink any booze
            //// between 16 and 21 -> drink beer
            //// older then 21 -> you can drink everything you want
            //// SOLUTION1
            ////if (age < 16)
            ////{
            ////    // true lane
            ////    Console.WriteLine("You are younger then 16, only drink non-alcoholic drinks");
            ////} else
            ////{
            ////    // false lane
            ////    if (age < 21)
            ////    {
            ////        Console.WriteLine("You can only drink beer");
            ////    } else
            ////    {
            ////        Console.WriteLine("You can drink everything you want");
            ////    }
            ////}

            //if (age < 16 )
            //{
            //    Console.WriteLine("Drink fanta");
            //} else if (age < 21)
            //{
            //    Console.WriteLine("Drink fanta or beer");
            //} else
            //{
            //    Console.WriteLine("Drink cuba libre");
            //}



            // WEEKDAY
            // 1 -> return monday
            // 2 -> return tuesday

            //int dayOfWeek = Convert.ToInt16(Console.ReadLine());

            //if (dayOfWeek == 1)
            //{
            //    Console.WriteLine("Monday");
            //} else if (dayOfWeek == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //} else if (dayOfWeek == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //} else
            //{
            //    Console.WriteLine("Other day of the week");
            //}

            //switch (dayOfWeek)
            //{
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("Other day of the week");
            //        break;
            //}


            // FRUITS CHECKER

            // FRUIT (apple, orange, banana)

            // O: give me a fruit (apple, orange, banana)
            // I: apple
            // O: an apple a days keeps the doctor away

            // O: give me a fruit (apple, orange, banana)
            // I: orange
            // O: orange joke hahaha

            // O: give me a fruit (apple, orange, banana)
            // I: banana
            // O: r u a monkey?

            // O: give me a fruit (apple, orange, banana)
            // I: kiwi
            // O: i don't know that fruit

            //Console.WriteLine("give me a fruit (apple, orange, banana)");
            //string userFruit = Console.ReadLine();

            //switch (userFruit) {
            //    case "orange":
            //        Console.WriteLine("orange joke hahaha");
            //        break;
            //    case "banana":
            //        Console.WriteLine("r u a monkey?");
            //        break;
            //    case "apple":
            //        Console.WriteLine("an apple a days keeps the doctor away");
            //        break;
            //    default:
            //        Console.WriteLine("I don't know what you are talking about");
            //        break;
            //}





            // multiplcation table
            // 2 * 0 = 0
            // 2 * 1 = 2
            // 2 * 2 = 4
            // 2 * 3 = 6
            // ..
            // 2 * 10 = 20

            //int userNumber = Convert.ToInt16(Console.ReadLine());

            //// x++
            //// x += 1
            //// x = x + 1

            //// count up 
            //for (int x = 0; x <= 10; x++)
            //{
            //    int result = x * userNumber;
            //    Console.WriteLine($"{userNumber} * {x} = {result}");
            //}

            //// count down 
            //for (int x = 10; x >= 0; x--)
            //{
            //    int result = x * userNumber;
            //    Console.WriteLine($"{userNumber} * {x} = {result}");
            //}

            //// multiplication of even number 
            //for (int x = 10; x >= 0; x-=2)
            //{
            //    int result = x * userNumber;
            //    Console.WriteLine($"{userNumber} * {x} = {result}");
            //}

            //// multiplication of even number 
            //for (int x = 10; x >= 0; x --)
            //{
            //    if (x % 2 == 0)
            //    {
            //        int result = x * userNumber;
            //        Console.WriteLine($"{userNumber} * {x} = {result}");
            //    }
            //}


            //for (int x = 0; x <= 10; x++)
            //{
            //    Console.WriteLine(x);
            //}


            //for (int x = 0; x < 3; x++)
            //{
            //    // x = 1 
            //    for (int y = 0; y < 3; y++)
            //    {
            //        // y = 0
            //        Console.WriteLine($"{x} * {y} = {x * y}");
            //    }
            //}

            // O: 0 * 0 = 0
            // O: 0 * 1 = 0
            // O: 0 * 2 = 0

            // O: 1 * 0 = 0
            // O: 1 * 1 = 1
            // O: 1 * 2 = 2

            // O: 2 * 0 = 0
            // O: 2 * 1 = 2
            // O: 2 * 2 = 4



            //string fruit = Console.ReadLine();

            //while (fruit != "banana")
            //{
            //    Console.WriteLine("Whut???");
            //    fruit = Console.ReadLine();
            //}

            //Console.WriteLine("I like banana's");


            //for (int x = 0; x <= 10; x++)
            //{
            //    Console.WriteLine(x);
            //}


            //int number2 = 20;

            //while (number2 <= 10)
            //{
            //    Console.WriteLine(number2);

            //    number2 = number2 + 1;
            //}






            // Username: collin
            // Password: omg

            // O: Give me your username:
            // I: collin
            // O: Give me your password:
            // I: om
            // O: NOT CORRECT

            // O: Give me your username:
            // I: collin
            // O: Give me your password:
            // I: omg
            // O: YOU ARE LOGGED IN

            // && -> and operations ( all expressions are true)
            // || -> or operations (at least 1 expressions is true

            //Console.WriteLine("Give me your username");
            //string username = Console.ReadLine();

            //Console.WriteLine("Give me your password");
            //string password = Console.ReadLine();

            //while (username != "collin" && password != "omg")
            //{
            //    Console.WriteLine("Not correct");

            //    Console.WriteLine("Give me your username");
            //    username = Console.ReadLine();

            //    Console.WriteLine("Give me your password");
            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("You are logged in");

            //int number = Convert.ToInt16(Console.ReadLine());

            //while (number <= 10)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}


            //do
            //{
            //    Console.WriteLine(number);
            //    number++;
            //} while (number <= 10);


            // CHECK BY IF
            string numberString = Console.ReadLine(); // 5 => "5", 5.5 => "5.5
            int number;

            bool validation = Int32.TryParse(numberString, out number);

            while (validation == false) {
                Console.WriteLine("Wrong user input");
                numberString = Console.ReadLine();

                validation = Int32.TryParse(numberString, out number);
            }

            if (validation)
            {
                int result = number + 10;

                Console.WriteLine(result);
            }

        }
    }
}


//
// recap if/else/else if
//






//
// Explanation weekdays with switch 
//







//
// Try Parse 
//





//
// The mighty for loop
// count from 1 to 10 
//





//
// The mighty for loop
// count from 10 to 1 
//





//
// The mighty for loop
// count only even numbers from 1 to 10
//



//
// Multiplication table
//




//
// Loop in loop
//





//
// while loop
//




//
// for loop to while loop
//






//
// BUTCHER
// PRICE OF SAUSAGE: 5.5
// ASK HOW MUCH KG TO THE USER
// SAY HOW MUCH IT COST AND ASK FOR MONEY
// IF MONEY IS CORRECT, JUST GIVE THE SAUSAGES
// IF MONEY IS TO LOW, ASK FOR MORE MONEY
// IF MONEY IS TO HIGH, GIVE CASH MONEY
//
// FE:
// O: Hello, how many kg sausages do you want?
// I: 2
// O: Sweet, that will be 11 euros please
// I: 11
// O: Here are your sausages
//

// FE:
// O: Hello, how many kg sausages do you want?
// I: 2
// O: Sweet, that will be 11 euros please
// I: 13
// O: Here are your sausages and 2 euros
//