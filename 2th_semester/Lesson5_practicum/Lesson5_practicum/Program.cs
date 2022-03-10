using System;
using System.IO;

namespace Lesson5_practicum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //
            // Read the spotify.txt and output the songs
            // O: jilly beillish - oceans eyes
            // O: bustin jieber - lets dance
            // O: dj collinator - programming song
            //
            //StreamReader input = File.OpenText("spotify.txt");

            //while (!input.EndOfStream)
            //{
            //    string line = input.ReadLine();
            //    Console.WriteLine(line);
            //}

            //input.Close();





            //
            // Save 1 to 10 to a txt file
            //
            //StreamWriter output = File.CreateText("output.txt");

            //for (int x = 1; x <= 10; x++)
            //{
            //    output.WriteLine(x);
            //}

            //output.Close();




            //
            // Speeding application
            // zone1: 30km -> 50 euro
            // zone2: 50km -> 75 euro
            // zone3: 70km -> 125 euro
            // zone4: 90km -> 180 euro
            //
            // O: Everytime you open program you first have to say which zone the speeding application is
            // I: zone1
            // O: You are in zone1 which means 50 euro fine, type a number
            // O: and check if you got fine type, STOP to exit program 
            // I: 25
            // O: No fine
            // I: 40
            // O: 50 euro fine
            // I: STOP

            Console.WriteLine("Location:");
            string zone = Console.ReadLine();

            string commando = Console.ReadLine(); // "STOP", "40"

            while (commando.ToLower() != "stop")
            {
                int speed = Convert.ToInt32(commando);
                int fine = 0;

                switch (zone)
                {
                    case "zone1":
                        if (speed > 30) fine = 50;
                        break;
                    case "zone2":
                        if (speed > 50) fine = 75;
                        break;
                    case "zone3":
                        if (speed > 70) fine = 125;
                        break;
                    case "zone4":
                        if (speed > 90) fine = 180;
                        break;
                }

                if (fine == 0)
                {
                    Console.WriteLine("No fine");
                } else
                {
                    Console.WriteLine($"{fine} euro");

                    StreamWriter fineOutput = File.AppendText("fine.txt");
                    fineOutput.WriteLine($"{speed}km in {zone} = {fine}euro");
                    fineOutput.Close();
                }

                commando = Console.ReadLine();
            }



        }
    }
}




























//
// Accountancy application
// O: [OVERVIEW] show you every line
// O: [OUTGOING] add outgoing invoice total
// O: [INCOMING] add incoming invoice total
// O: [RESULT] counts everything and give you a result
// O: [STOP] will exit the program
//
//
// I: OUTGOING
// I: 400
// O: add 400 to a file
//
// I: INCOMING
// I: 500
// O: add -500 to a file
//
// I: OVERVIEW
// O: 400
// O: -500
//
// I: RESULT
// O: -100
//
// I: STOP