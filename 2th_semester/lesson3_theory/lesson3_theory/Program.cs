using System;

namespace lesson3_theory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //int number1 = 15;
            //int number2 = 15;

            //Console.WriteLine(number1 < number2);
            //Console.WriteLine(number1 <= number2);
            //Console.WriteLine(number1 > number2);
            //Console.WriteLine(number1 >= number2);
            //Console.WriteLine(number1 == number2);

            //// BOUNCER APPLICATION
            //Console.WriteLine("Give me your age:");
            //int age = Convert.ToInt16(Console.ReadLine());

            //// IF age is greater then 18 execute whatever is in the { } 
            //if (age < 18)
            //{
            //    // WHENEVER IT IS TRUE
            //    // EXECUTE THIS CODE
            //    Console.WriteLine("NOT WELCOME, 2 YOUNG!");
            //} else if (age > 65)
            //{
            //    Console.WriteLine("NOT WELCOME, 2 old");
            //} else
            //{
            //    // WHENEVER THE EXPRESSION IS SET TO FALSE
            //    // EXECUTE THIS CODE
            //    Console.WriteLine("YOU ARE WELCOME");
            //}




            //
            // ASK FOR 2 NUMBERS
            // CHECK IF THE FIRST NUMBER IS BIGGER THEN SECOND NUMBER
            //
            // O: GIVE ME NUMBER 1:
            // I: 5
            // O: GIVE ME NUMBER 2:
            // I: 10
            // O: NUMBER 1 IS NOT BIGGER THEN NUMBER 2


            // O: GIVE ME NUMBER 1:
            // I: 16
            // O: GIVE ME NUMBER 2:
            // I: 10
            // O: NUMBER 1 IS BIGGER THEN NUMBER 2


            // O: GIVE ME NUMBER 1:
            // I: 15
            // O: GIVE ME NUMBER 2:
            // I: 15
            // O: NUMBER 1 IS THE SAME NUMBER AS NUMBER 2

            //Console.WriteLine("GIVE ME NUMBER 1");
            //int number1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("GIVE ME NUMBER 2");
            //int number2 = Convert.ToInt32(Console.ReadLine());

            //if (number1 < number2)
            //{
            //    // whenever expression is true
            //    Console.WriteLine("NUMBER 1 IS NOT BIGGER THEN NUMBER 2");
            //} else if (number1 == number2)
            //{
            //    Console.WriteLine("NUMBER 1 IS THE SAME NUMBER AS NUMBER 2");
            //} else
            //{
            //    // whenever expression is false
            //    Console.WriteLine("NUMBER 1 IS BIGGER THEN NUMBER 2");
            //}

            //if (number1 == number2)
            //{
            //    Console.WriteLine("This is the same");
            //} else
            //{
            //    if (number1 < number2)
            //    {
            //        // whenever expression is true
            //        Console.WriteLine("NUMBER 1 IS NOT BIGGER THEN NUMBER 2");
            //    } else
            //    {
            //        Console.WriteLine("NUMBER 1 IS BIGGER THEN NUMBER 2");
            //    }
            //}





            //
            // ASK FOR NUMBER BETWEEN 1 - 7 (1 is monday, 7 sunday)
            // FE
            // I: 1
            // O: WEEKDAY
            // O: MONDAY
            //
            // FE2:
            // I: 3
            // O: WEEKDAY
            // O: WEDNESDAY
            //

            // FE2:
            // I: 6
            // O: YAAY IT IS WEEKEND
            // O: SATURDAY
            //
            //int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            //if (dayOfWeek < 6)
            //{
            //    // Weekday
            //    Console.WriteLine("OH no we have to go school");

            //    // tell them day of the week
            //    if (dayOfWeek == 1)
            //    {
            //        Console.WriteLine("Monday");
            //    }
            //    else if (dayOfWeek == 2)
            //    {
            //        Console.WriteLine("Tuesday");
            //    }
            //    else if (dayOfWeek == 3)
            //    {
            //        Console.WriteLine("Wednesday");
            //    }
            //    else if (dayOfWeek == 4)
            //    {
            //        Console.WriteLine("Thursday");
            //    }
            //    else if (dayOfWeek == 5)
            //    {
            //        Console.WriteLine("Friday");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("PARTY IT IS WEEKEND");

            //    if (dayOfWeek == 6)
            //    {
            //        Console.WriteLine("Saturday");
            //    }
            //    else if (dayOfWeek == 7)
            //    {
            //        Console.WriteLine("Sunday");
            //    }
            //}



            //int number1 = 5;
            //int number2 = 10;

            //if (number1 == number2)
            //{
            //    Console.WriteLine("THE SAME");
            //} else
            //{
            //    Console.WriteLine("NOT THE SAME");
            //}

            //if (number1 != number2)
            //{
            //    Console.WriteLine("NOT THE SAME");
            //}
            //else
            //{
            //    Console.WriteLine("THE SAME");
            //}

            //Boolean isFemale = true;
            //string password = "collin";
            //if (password == "collin")
            //{
            //    Console.WriteLine("Hello mrs");
            //}

            //string username = "collinvdv";
            //string password = "collin!";

            //string inputUsername = Console.ReadLine();
            //string inputPassword = Console.ReadLine();

            //// AND-operator = &&  ALL EXPRESSIONS SHOULD BE SET ON TRUE
            //// OR-operator == || 
            //if (username == inputUsername || password == inputPassword)
            //{
            //    Console.WriteLine("AUTHENTICATED");
            //} else
            //{
            //    Console.WriteLine("NOT AUTHENTICATED");
            //}



            // 
            // THE BOUNCER APPLICATION
            //
            // AGE older or equal then 21
            //

            // O: WELCOME TO TOMORROWLAND
            // O: WHAT IS YOUR AGE?
            // I: 21
            // O: WHAT GENDER DO YOU HAVE? (type F or M)
            // I: M
            // O: GO THE F* AWAY
            //
            // O: WELCOME TO TOMORROWLAND
            // O: WHAT IS YOUR AGE?
            // O: WHAT GENDER DO YOU HAVE? (type F or M)
            // I: F
            // I: 18
            // O: GO THE F* AWAY
            //
            // O: WELCOME TO TOMORROWLAND
            // O: WHAT IS YOUR AGE?
            // I: 21
            // O: WHAT GENDER DO YOU HAVE? (type F or M)
            // I: F
            // O: GO THE F* AWAY

            // O: WELCOME TO TOMORROWLAND
            // O: WHAT IS YOUR AGE?
            // I: 21
            // O: WHAT GENDER DO YOU HAVE? (type F or M)
            // I: M
            // O: Pssst, you can also give me some money (like 1000)
            // I: 1000
            // O: ENTER

            Console.WriteLine("WELCOME TO TOMORROWLAND");
            Console.WriteLine("WHAT IS YOUR AGE?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("WHAT GENDER DO YOU HAVE? (type F or M)");
            string gender = Console.ReadLine();

            Console.WriteLine("Pssst, you can also give me some money (like 1000)");
            int money = Convert.ToInt32(Console.ReadLine());

            //f 22 0
            //m 22 0
            //m 22 1001

            if ( (age >= 21 && gender == "F") || money > 1000)
            {
                Console.WriteLine("ENTER");
            } else
            {
                Console.WriteLine("GO THE F* AWAY");
            }
        }
    }
}
//
// INTRODUCTION
//



































//
// ASK FOR NUMBER BETWEEN 1 - 7 (1 is monday, 7 sunday)
// FE
// I: 1
// O: MONDAY
//
// FE2:
// I: 3
// O: WEDNESDAY
//







//
// PASSWORD CHECK (USER: COLLIN , PASSWORD:ALMOSTWEEKEND)
//












//
// ASK FOR NUMBER BETWEEN 1 - 7 (1 is monday, 7 sunday)
// FE
// I: 1
// O: MONDAY
// O: THIS IS A WEEKDAY
//
// FE2:
// I: 6
// O: FRIDAY
// O: YAAY WEEKEND
//












//
// THE BOUNCER APPLICATION PART 1
// ASK FOR THE AGE, WHEN OLDER THEN 18 DON'T LET THEM IN!!!
//
























//
// THE BOUNCER APPLICATION PART 2
// 2 MUCH BOYS, ONLY ALLOW GIRLS THAT ARE OLDER THEN 18
//






















//
// THE BOUNCER APPLICATION PART 2
// 2 MUCH BOYS, ONLY ALLOW GIRLS THAT ARE OLDER THEN 18
// ALSO POSSIBLE TO BRIBE ME
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
