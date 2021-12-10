using System;
using System.IO;
using System.Text.RegularExpressions;

namespace fileIn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //StreamReader input = File.OpenText("students.txt");

            // **** READ THE WHOLE FILE
            // .ReadToEnd() => fully read the file and give it back into a string
            //string fileText = input.ReadToEnd();
            //Console.WriteLine(fileText);

            // **** READ THE FILE LINE BY LINE
            // .ReadToLine() => everytime it is execute will go to the next line
            //string line = input.ReadLine();
            //int lineNumber = 1;

            //while (line != null)
            //{
            //    Console.WriteLine($"Student {lineNumber} is " + line);
            //    line = input.ReadLine();
            //    lineNumber++;
            //}

            // **** READ THE FILE CHAR BY CHAR
            // .Read() => this will be CHAR
            //char character = Convert.ToChar(input.Read());

            //while (!input.EndOfStream)
            //{
            //    character = Convert.ToChar(input.Read());
            //    Console.WriteLine(character);
            //}


            // *** USE THE FOREACH LOOP TO LOOP OVER AN ARRAY
            //string line = input.ReadLine();
            //string text = input.ReadToEnd(); //"collin connor justin"

            //foreach (char c in text)
            //{
            //    Console.WriteLine(c);
            //}

            // *** CREATE A NEW FILE
            // Create a new file where we execute code upon
            //StreamWriter output = File.CreateText("students_v2.txt"); //THIS WILL CREATE OR OVERWRITE A FILE
            //StreamWriter output = File.AppendText("students_v2.txt"); // THIS WILL ADD SOMETHING TO NEW TO AN EXISTING FILE

            //output.WriteLine("This is my first file OMG I'm a genius");
            //output.WriteLine("This is my second line, OMG I'm a genius");

            //output.Close();


            // *** CREATE A LOG SYSTEM WHENEVER A GUEST IS LOGGED IN OUTPUT IT TO A FILE
            // INPUT: collin
            // store in a file: log.txt
            //Boolean fileExisting = File.Exists("log.txt");
            //string guest = Console.ReadLine();

            //if (guest == "delete")
            //{
            //    File.Delete("log.txt");
            //} else
            //{
            //    if (fileExisting)
            //    {
            //        // File is existing add new line to the file
            //        StreamWriter output = File.AppendText("log.txt");
            //        output.WriteLine($"Guest {guest} has entered the building");
            //        output.Close();
            //    } else
            //    {
            //        // Create new file
            //        StreamWriter output = File.CreateText("log.txt");
            //        output.WriteLine($"Guest {guest} has entered the building");
            //        output.Close();
            //    }
            //}


            // *** STRING
            //string name = "Collin Van der Vorst"; //COLLIN VAN DER VORST
            //string name2 = "COlLin VaN dEr Vorst"; //COLLIN VAN DER VORST

            //Console.WriteLine(name == name2);
            //Console.WriteLine(name.ToUpper() == name2.ToUpper()); //.ToUpper() will make everything in capitals
            //Console.WriteLine(name.ToLower() == name2.ToLower()); //.ToLower() will put everything in small letters

            //string givenWord = Console.ReadLine();
            //string phrase = "Collin the Collin makes delicious pancakes";
            //Boolean hasGivenWordInPhrase = phrase.ToLower().Contains(givenWord);
            //Boolean startsWithGivenWord = phrase.ToLower().StartsWith(givenWord);
            //int locationOfGivenWord = phrase.ToLower().IndexOf(givenWord);

            //Console.WriteLine(hasGivenWordInPhrase);
            //Console.WriteLine(startsWithGivenWord);
            //Console.WriteLine(locationOfGivenWord);

            //phrase = phrase.Insert(6, " Van der Vorst ");

            //phrase = phrase.Replace("Collin", "God");
            //Console.WriteLine(phrase);

            //Console.WriteLine(phrase.Substring(phrase.Length - 10));


            // A given text file
            StreamReader input = File.OpenText("loremipsum.txt");
            string fullText = input.ReadToEnd();
            //string[] words = fullText.Split(' ');
            //int countWord = 0;
            ////doloremipsum
            //foreach(string word in words)
            //{
            //    if (word.Contains("dolorem"))
            //    {
            //        countWord++;
            //    }
            //}

            //Console.WriteLine("The amount of words is:" + countWord);

            Regex rx = new Regex(@"dolorem", RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(fullText);
            Console.WriteLine(matches.Count);

        }
    }
}


// Exercise 3: read every character seperately
// Exercise 4: read every character seperately by using foreach loop
// Exercise 5: create file
// Exercise 6: append to a file
// Exercise 7: do the test assignment
// Exercise 8: String functions
// Exercise 9: Regex




// That is it!