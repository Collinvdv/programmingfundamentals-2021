using System;

namespace Lesson10_practicum
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // area of circle (A = π r²)
            // area of rectangle (A = height * width)

            // What area calculate? [CIRCLE OR RECTANGLE]
            // I: rectangle
            // O: give me height
            // I: 10
            // O: give me width
            // I: 5
            // O: The result is 50

            // calculateAreaOfRectangle(10, 5)


            // What area calculate? [CIRCLE OR RECTANGLE]
            // I: CIRCLE
            // O: give me radius
            // I: 10
            // O: The result is 314

            // calculateAreaOfCircle(10)

            string command = Console.ReadLine(); // circle or rectangle

            switch (command.ToLower())
            {
                case "circle":
                    double areaCircle = AreaCircle();
                    PrintArea(areaCircle);
                    break;

                case "rectangle":
                    double areaRectangle = AreaRectangle();
                    PrintArea(areaRectangle);
                    break;
            }
        }

        static void PrintArea(double area)
        {
            Console.WriteLine("The result is " + area);
        }

        static double AreaCircle()
        {
            Console.WriteLine("give me radius");
            double radius = Convert.ToDouble(Console.ReadLine());

            return radius * radius * Math.PI;
        }

        static double AreaRectangle()
        {
            // Ask the height
            Console.WriteLine("Give me the height");
            double height = Convert.ToDouble(Console.ReadLine());

            // Ask the Width
            Console.WriteLine("Give me the width");
            double width = Convert.ToDouble(Console.ReadLine());

            // Calculate area
            return height * width;
        }
     
    }
}






















// AWESOME BANDNAME GENERATOR with 3 words
// { "the", "a", "not", "all"} => give me 1 random item back
// { "ugly", "awesome", "nice", "perfect", "hardcore"} => give me 1 random item back
// { "pigeon", "student", "bird", "flower", "jebus", "santan"} => give me 1 random item back
// Command YES or ADD NEW  to add new band name, Command STOP to stop the game

// O: Hello to my crazy band generator

// O: You want to know a new band?
// I: YES
// O: the awesome jebus

// O: You want to know a new band?
// I: YES
// O: not ugly pigeon

// O: You want to know a new band?
// I: STOP
// O: THXBEY


















// SPOTIFY (WHUT AGAIN)
// FASE 1:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO THE SONG "YELLOW SUBMARINE" OVERWRITE?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//         ----- SUBCASE 2.1
//         I: N
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: LIST SONGS
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO









// SPOTIFY ARTIST CAN HAVE MULTIPLE SONGS
// FASE 2:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: LIST SONGS
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO








// SPOTIFY RECOGNIZE LIST AND LIST SONGS
// FASE 3:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//   I: LIST SONGS
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: GIVE ME A SONG
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO








// SPOTIFY PLAY A SONG
// FASE 4:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: LIST SONGS
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: PLAY ME A SONG
//      ----- CASE 1 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: DUA LIPA - ONE KISS
//      O: PLAYING DUA LIPA
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: PEARL JAM - ALIVE
//      O: CAN NOT FIND THIS SONG
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: GIVE ME A SONG
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]











// SPOTIFY ARTIST PLAY A RANDOM SONG
// FASE 5:
// COMMANDS
//   I: LIST
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: LIST SONGS
//      O: DUA LIPA - ONE KISS
//      O: THE BEATLES - HEY JUDE
//      O: THE BEATLES - YELLOW SUBMARINE
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: ADD A SONG
//      ----- CASE 1 ------
//      O: ASK ARTIST
//      I: DUA LIPA
//      O: NEW ARTIST, CAN YOU GIVE ME THE SONG NAME?
//      I: ONE KISS
//      O: I'VE ADDED DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, ADD A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: ASK ARTIST
//      I: THE BEATLES
//      O: THE BEATLES IS IN LIST, DO YOU WANT TO TO ADD A NEW SONG?
//         ----- SUBCASE 2.1
//         I: Y
//         O: CAN YOU GIVE ME THE SONG?
//         I: HEY JUDE
//         O: I'VE ADDED THE BEATLES - HEY JUDE
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//         -----SUBCASE 2.2
//         I: N
//         O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: STOP
//      O: GOODBYE
//   I: PLAY ME A SONG
//      ----- CASE 1 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: DUA LIPA - ONE KISS
//      O: PLAYING DUA LIPA
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//
//      ----- CASE 2 ------
//      O: WHAT SONG DO YOU WANT TO HEAR?
//      I: PEARL JAM - ALIVE
//      O: CAN NOT FIND THIS SONG
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: PLAY ME A RANDOM SONG
//      O: PLAYING DUA LIPA - ONE KISS
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]
//   I: GIVE ME A SONG
//      O: ERROR, I DON'T RECOGNISE THE COMMANDO
//      O: GIVE NEW COMMANDO [LIST, LIST SONGS, ADD A SONG, PLAY A SONG, STOP]