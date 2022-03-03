using System;

namespace Lesson4_Practical
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1. CODEGRADE
            //string firstname = Console.ReadLine(); // elke
            //string familyname = Console.ReadLine(); // boonen
            //Console.WriteLine($"Hello {firstname} {familyname}!");


            //int age = 18;

            //if (age > 18)
            //{
            //    // TRUE
            //    Console.WriteLine("They are older then 18");

            //    if (age > 65)
            //    {
            //        Console.WriteLine("Damn, you are old");
            //    }
            //} else
            //{
            //    // False
            //    Console.WriteLine("The are younger then 18");
            //}


            //// FOR LOOP
            //for (int x = 1; x < 10; x++)
            //{
            //    Console.WriteLine(x);
            //}

            ////
            //string fruit = "orange";

            //if (fruit == "orange")
            //{
            //    Console.WriteLine("Orange I like");
            //} else if (fruit == "apple")
            //{
            //    Console.WriteLine("An apple day keeps the doctor away");
            //} else
            //{
            //    Console.WriteLine("Whuut?");
            //}

            //switch (fruit)
            //{
            //    case "orange":
            //        Console.WriteLine("Orange I like");
            //        break;
            //    case "apple":
            //        Console.WriteLine("An apple day keeps the doctor away");
            //        break;
            //    default:
            //        Console.WriteLine("Whuut?");
            //        break;
            //}

            // while loop
            //string commando = Console.ReadLine();

            //while (commando != "STOP")
            //{
            //    Console.WriteLine("Autwtch");

            //    commando = Console.ReadLine();
            //}





            //
            // What can I drink application?
            // Age younger then 16 = drink soda
            // Age younger then 18 = drink soda or beer
            // Older then 18 = drink everything
            //
            // O: What is your age?
            // I: 14
            // O: drink soda
            //
            // O: What is your age?
            // I: 17
            // O: drink soda or beer
            //
            // O: What is your age?
            // I: 19
            // O: drink everything
            //
            //Console.WriteLine("What is your age?");
            //int age = Convert.ToInt32(Console.ReadLine());

            //if (age < 16)
            //{
            //    Console.WriteLine("drink soda");
            //} else if (age < 18)
            //{
            //    Console.WriteLine("drink soda or beer");
            //} else
            //{
            //    Console.WriteLine("drink everything");
            //}




            //
            // Calculate the sum of all numbers from 1 to a given number
            // For example,
            // if the user entered 10 the output should be 55 (1+2+3+4+5+6+7+8+9+10)
            //
            // I: 10
            // O: 55
            //
            //int number = Convert.ToInt32(Console.ReadLine()); // 10
            //int result = 0;

            //for (int x = 1; x <= number; x++)
            //{
            //    result += x;
            //}

            //Console.WriteLine(result);

            //
            // Multiplication table
            //
            // O : What number do you want to multiply? 
            // I : 5
            // O : How many times?
            // I : 3
            // O : 0 x 5 = 0
            // O : 1 x 5 = 5
            // O : 2 x 5 = 10
            // 

            //Console.WriteLine("What number do you want to multiply?");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("How many times?");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int x = 0; x < rows; x++)
            //{
            //    int result = x * number;
            //    Console.WriteLine($"{x} x {number} = {result}");
            //}

            //
            // Give me the odd numbers from a range
            //
            // O: What is your starting point?
            // I: 40
            // O: What is your endpoint?
            // I: 50
            // O: 41, 43, 45, 47, 49
            //
            //int startingPoint = Convert.ToInt32(Console.ReadLine());
            //int endPoint = Convert.ToInt32(Console.ReadLine());


            //for (int number = startingPoint + 1; number < endPoint; number++)
            //{
            //    if (number % 2 == 1 )
            //    {
            //        if (number == endPoint - 1)
            //        {
            //            Console.Write(number);
            //        } else
            //        {
            //            Console.Write(number + ", ");
            //        }
            //    }
            //}




            //
            // Is it party time yet?
            // When monday/tuesday/wednesday/thursday => no
            // When friday/saturday/sunday => yes 
            //
            // O : What day of the week is it?
            // I : monday
            // O : No party
            //
            // O : What day of the week is it?
            // I : friday
            // O : Party
            //
            // O : What day of the week is it?
            // I : friyay
            // O : that is not a day of the week

            //Console.WriteLine("What day of the week is it?");
            //string dayOfWeek = Console.ReadLine();

            //if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday")
            //{
            //    Console.WriteLine("NO PARTY, PROGRAMMING FUNDAMENTALS ASSIGNMENTS");
            //} else if (dayOfWeek == "friday" || dayOfWeek == "saturday" || dayOfWeek == "sunday" )
            //{
            //    Console.WriteLine("Party, yihaah!");
            //} else
            //{
            //    Console.WriteLine("That is not a day of the week");
            //}

            //string noParty = "NO PARTY, PROGRAMMING FUNDAMENTALS ASSIGNMENTS";
            //string party = "PARTY, yihaah";

            //switch (dayOfWeek)
            //{
            //    case "monday":
            //        Console.WriteLine(noParty);
            //        break;
            //    case "tuesday":
            //        Console.WriteLine(noParty);
            //        break;
            //    case "wednesday":
            //        Console.WriteLine(noParty);
            //        break;
            //    case "thursday":
            //        Console.WriteLine(noParty);
            //        break;
            //    case "friday":
            //        Console.WriteLine(party);
            //        break;
            //    case "saturday":
            //        Console.WriteLine(party);
            //        break;
            //    case "sunday":
            //        Console.WriteLine(party);
            //        break;
            //    default:
            //        Console.WriteLine("I don't know what you are talking about");
            //        break;

            //}





            //
            // Accountancy application
            //
            // O: add a number or say STOP to end and see result
            // I: 100
            // I: 50
            // I: 250
            // I: -100
            // I: -200
            // I: STOP
            // O: Your profit is 100 euro
            //
            // O: add a number or say STOP to end and see result
            // I: 100
            // I: 50
            // I: 250
            // I: -100
            // I: -400
            // I: STOP
            // O: Your loss is 100 euro
            //









            //Console.WriteLine("add a number or say STOP to end and see result");
            //string command = Console.ReadLine();
            //int result = 0;

            //while (command != "STOP")
            //{
            //    int number; 
            //    bool commandIsNumber = Int32.TryParse(command, out number);

            //    if (commandIsNumber)
            //    {
            //        result += number;
            //    }

            //    command = Console.ReadLine();
            //}

            //if (result > 0)
            //{
            //    Console.WriteLine($"Your profit is {result} euro");
            //} else
            //{
            //    int absResult = Math.Abs(result);
            //    Console.WriteLine($"Your loss is {absResult} euro");
            //}




            double number1 = 4.5;

            Console.WriteLine(Math.Floor(number1)); // round down to the bottom
            Console.WriteLine(Math.Abs(number1)); // give postive number
            Console.WriteLine(Math.Ceiling(number1)); // round up
        }
    }
}














































//
// Tommorowland
// only females between 18 and 30
// only males between 21 and 30
// bribe money >= 1000 let them enter
//
// O: What is your age?
// I: 20
// O: What is your gender
// I: f
// O: You can enter!
//
//
// O: What is your age?
// I: 40
// O: What is your gender
// I: f
// O: You can not enter, what is the amount of bribe money
// I: O
// O: GO AWAY THEN
//
// O: What is your age?
// I: 40
// O: What is your gender
// I: f
// O: You can not enter, what is the amount of bribe money
// I: 100O
// O: Enter but ssssttt 
//
