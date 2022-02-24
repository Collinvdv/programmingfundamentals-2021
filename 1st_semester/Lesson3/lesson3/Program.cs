using System;

namespace lesson3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // 1kg of sweet sweet sausages is 5EURO
            //double customerMoney = Convert.ToDouble(Console.ReadLine());
            //double priceOfSausages = 5;

            // Example 1 
            //if (customerMoney == priceOfSausages) {
            //    // expression is true
            //    Console.WriteLine("Thanks bro, here are you sausages.");
            //} else if(customerMoney > priceOfSausages)
            //{
            //    // expression is true
            //    Console.WriteLine("I'll come back at you with your change.");
            //} else
            //{
            //    Console.WriteLine("I KNOW WHERE YOU LIVE, YOU'RE GONNA DIE");
            //}

            // Example 2: same solution, written differntly
            //if (customerMoney == priceOfSausages)
            //{
            //    // The amount of money is correct, you don't anything
            //    Console.WriteLine("Here you go Sir, have a nice meal");
            //} else
            //{
            //    // I have to do something
            //    Console.WriteLine("I guess I have to something");

            //    if (customerMoney > priceOfSausages)
            //    {
            //        // True lane
            //        Console.WriteLine("I come back with your change");
            //    } else
            //    {
            //        // False lane
            //        Console.WriteLine("I'm going to kill you with my butchers knife");
            //    }
            //}


            // User: collin
            // Password: squidgame
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //if (username == "collin")
            //{
            //    // True lane
            //    Console.WriteLine("Hello Collin, I am going to check the password");


            //    if (password == "squidgame")
            //    {
            //        Console.WriteLine("Password is correct, enter");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sorry, I have to kill you");
            //    }

            //} else
            //{
            //    // False lane
            //    Console.Write("Who are you?");
            //}


            // Speedcamera exercice

            // zone 30km -> fine 120EURO
            // zone 50km -> fine 90EURO
            // zone 70km -> fine 70EURO
            // zone 90km -> fine 50EURO
            // zone 120km -> fine 30EURO

            // input: 65

            // output
            // You wil be fined for 120EUR if you are in zone 30
            // You wil be fined for 90EUR if you are in zone 50

            // input: 50

            // output
            // You wil be fined for 120EUR if you are in zone 30

            // input: 91

            // output
            // You wil be fined for 120EUR if you are in zone 30
            // You wil be fined for 90EUR if you are in zone 50
            // You wil be fined for 70EUR if you are in zone 70
            // You wil be fined for 50EUR if you are in zone 90

            //int speed = Convert.ToInt32(Console.ReadLine());

            //int zone1 = 30;
            //int zone2 = 50;
            //int zone3 = 70;
            //int zone4 = 90;
            //int zone5 = 120;

            ////Zone 1
            //if (speed > zone1)
            //{
            //    Console.WriteLine("You wil be fined for 120EUR if you are in zone 30");
            //}

            ////Zone 2
            //if (speed > zone2)
            //{
            //    Console.WriteLine("You wil be fined for 90EUR if you are in zone 50");
            //}

            ////Zone 3
            //if (speed > zone3)
            //{
            //    Console.WriteLine("You wil be fined for 70EUR if you are in zone 70");
            //}

            ////Zone 4
            //if (speed > zone4)
            //{
            //    Console.WriteLine("You wil be fined for 50EUR if you are in zone 90");
            //}

            ////Zone 5
            //if (speed > zone5)
            //{
            //    Console.WriteLine("You wil be fined for 30EUR if you are in zone 120");
            //}

            //int number1 = Convert.ToInt32(Console.ReadLine());

            //if (number1 < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else if (number1 < 10)
            //{
            //    Console.WriteLine("smaller then 10");
            //}
            //else if (number1 < 20)
            //{
            //    Console.WriteLine("smaller then 20");

            //} else
            //{
            //    Console.WriteLine("Bigger then 20");
            //}

            // User: collin
            // Password: squidgame
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //if (username == "collin" && password=="squidgame")
            //{
            //    // password AND username are the same, let him enter
            //    Console.WriteLine("You can entah");
            //} else
            //{
            //    // if not, kick him out
            //    Console.WriteLine("Go away, I don't know you");
            //}

            // beer or tequilla exercice

            //string codename = Console.ReadLine();

            //if (codename == "beer")
            //{
            //    Console.WriteLine("Entah");
            //} else if(codename == "tequilla")
            //{
            //    Console.WriteLine("Entah");
            //} else
            //{
            //    Console.WriteLine("Go away");
            //}

            //if (codename == "beer" || codename == "tequilla")
            //{
            //    Console.WriteLine("Enter");
            //} else
            //{
            //    Console.WriteLine("Go away");
            //}

            // User: collin
            // Password: squidgame or tequilla
            //string username = Console.ReadLine();
            //string password = Console.ReadLine();

            //if (username == "collin" && (password == "squidgame" || password == "tequilla") )
            //{
            //    // password AND username are the same, let him enter
            //    Console.WriteLine("You can entah");
            //}
            //else
            //{
            //    // if not, kick him out
            //    Console.WriteLine("Go away, I don't know you");
            //}


            // Create a program where only +18 people come but they have to be younger then 30 AND gender needs to f OR you bribed me
            // input: 19
            // input: f
            // input: 0
            // output: you can enter because you are equal or older then 18 and younger then 30 AND gender needs to f OR you bribed me


            // input: 18
            // input: f
            // input: 0
            // output: you can enter because you are equal or older then 18 and younger then 30 AND gender needs to f OR you bribed me

            // input: 17
            // input: f
            // input: 0
            // output: Go to school

            // input: 31
            // input: f
            // input: 100
            // output: you can enter because you are equal or older then 18 and younger then 30 AND gender needs to f OR you bribed me


            // input: 31
            // input: f
            // input: 0
            // output: You are to old for this party

            //int age = Convert.ToInt32(Console.ReadLine());
            //string gender = Console.ReadLine();
            //int money = Convert.ToInt32(Console.ReadLine());

            //if( (age >= 18 && age < 30 && gender == "f") || money >= 100 )
            //{
            //    Console.WriteLine("you can enter because you are equal or older then 18 and younger then 30 and gender is an f");
            //} else
            //{
            //    if (age < 18)
            //    {
            //        Console.WriteLine("Go to school");
            //    }

            //    if (age >= 30)
            //    {
            //        Console.WriteLine("You are to old for this party");
            //    }
            //}

            // Give me the number of the day of the week, I will give you the correct day

            // input: 1
            // output: monday

            // input: 3
            // output: wednesday

            // input: 8
            // output: Not a day of the week, you fool.
            //int numberOfTheWeek = Convert.ToInt32(Console.ReadLine());

            //if (numberOfTheWeek == 1)
            //{
            //    Console.WriteLine("Monday"); 
            //}
            //    else if(numberOfTheWeek == 2)
            //{
            //    Console.WriteLine("Tuesday");
            //}
            //    else if(numberOfTheWeek == 3)
            //{
            //    Console.WriteLine("Wednesday");
            //}
            //    else if (numberOfTheWeek == 4)
            //{
            //    Console.WriteLine("Thursday");
            //}
            //    else if (numberOfTheWeek == 5)
            //{
            //    Console.WriteLine("Friday");
            //}
            //    else if (numberOfTheWeek == 6)
            //{
            //    Console.WriteLine("Saturday");
            //}
            //    else if (numberOfTheWeek == 7)
            //{
            //    Console.WriteLine("Sunday");
            //}
            //    else
            //{
            //    Console.WriteLine("Not a day of the week, you fool.");
            //}

            //switch(numberOfTheWeek) {
            //    case 1:
            //        Console.WriteLine("hellloooo");
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Not a day of the week, you fool.");
            //        break;
            //}

            //string inputNumber = Console.ReadLine(); // "5"

            //int number1;

            //Boolean checkNumber = Int32.TryParse(inputNumber, out number1);

            //if (checkNumber)
            //{
            //    Console.WriteLine("Thank you for giving me a correct input");
            //    number1 *= 2;
            //} else
            //{
            //    Console.WriteLine("What is this number you fool? I don't understand it!");
            //}


            // butcher
            // sausages kg = 5euros

            // Did they gave enough money? If not, say to them "GIVE ME MORE MONEY"
            // If yes then if it is equal you don't have to do anything, if it is more than you have to give to proper amount of coins

            // input 10
            // output 2x 2euro
            // output 1x 1euro

            // input 15
            // output 5x 2euro 

            // input 7
            // output 1x 2euro

            // input 22
            // output 8x 2euro
            // output 1x 1euro

            // input 20
            // output 7x 2euro
            // output 1x 1euro

            // input 4
            // output "GIVE ME MORE MONEY"

            // input 5
            // output "Here are your sausages


            int priceOfSausages = 5;
            int customerMoney = Convert.ToInt32(Console.ReadLine());

            int change = customerMoney - priceOfSausages;


            
            Console.WriteLine(change);

            if (customerMoney == priceOfSausages)
            {
                Console.WriteLine("Here are the sausages");
            } else
            {
                if (customerMoney < priceOfSausages)
                {
                    Console.WriteLine("GIVE ME MORE MONEY");
                } else
                {
                    Console.WriteLine("Give them money back");
                    int twoEuroCoin;
                    int oneEuroCoin;

                    // 15euro / 2 = 7.5 -> 7 x

                    twoEuroCoin = change / 2;
                    oneEuroCoin = change % 2;
                    Console.WriteLine($"{twoEuroCoin}x 2euro");

                    if (oneEuroCoin > 0)
                    {
                        Console.WriteLine($"{oneEuroCoin}x 1euro");
                    }
                }
            }

        }
    }
}
