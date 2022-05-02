using System;
using System.Collections.Generic;

namespace lesson10_band_generator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello to my crazy band generator");


            string commando = Console.ReadLine().ToLower();

            while (commando != "stop")
            {
                // Check commando
                switch (commando)
                {
                    case "yes":
                        CreateBandName();
                        break;

                    case "add new":
                        CreateBandName();
                        break;
                }

                // Ask commando again
                commando = Console.ReadLine().ToLower();
            }


            // Stop the program
            Console.WriteLine("THXBEY");
            

        }

        static void CreateBandName()
        {
            string[] list1 = { "the", "a", "not", "all" };
            string[] list2 = { "ugly", "awesome", "nice", "perfect", "hardcore" };
            string[] list3 = { "pigeon", "student", "bird", "flower", "jebus", "santan" };

            string word1 = RandomItem(list1);
            string word2 = RandomItem(list2);
            string word3 = RandomItem(list3);

            Console.WriteLine($"{word1} {word2} {word3}");
        }

        static string RandomItem(string[] list)
        {
            return list[RandomNumber(0, list.Length)];
        }

        static int RandomNumber(int minValue, int maxValue)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(minValue, maxValue);

            return randomIndex;
        }
    }
}

// AWESOME BANDNAME GENERATOR with 3 words
// { "the", "a", "not", "all"} => give me 1 random item back
// { } => give me 1 random item back
// { "pigeon", "student", "bird", "flower", "jebus", "santan"} => give me 1 random item back

// Command YES or ADD NEW to add new band name, Command STOP to stop the game

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


















// SPOTIFY 
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