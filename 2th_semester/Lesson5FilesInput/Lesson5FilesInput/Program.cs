using System;
using System.IO; // File, StreamReader, StreamWriter

namespace Lesson5FilesInput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            StreamReader guestbookReader = File.OpenText("guestbook.txt");

            // Use .ReadToEnd() to read the whole file, will return a string
            // Console.WriteLine(guestbookReader.ReadToEnd());

            int amountOfFemales = 0;
            int amountOfMales = 0;

            while (!guestbookReader.EndOfStream)
            {
                string line = guestbookReader.ReadLine();
                Console.WriteLine(line);

                if (line.StartsWith("M"))
                    amountOfMales++;

                if (line.StartsWith("F"))
                    amountOfFemales++;
            }

            Console.WriteLine($"Amount of males {amountOfMales}");
            Console.WriteLine($"Amount of females {amountOfFemales}");

            guestbookReader.Close();
        }
    }
}
