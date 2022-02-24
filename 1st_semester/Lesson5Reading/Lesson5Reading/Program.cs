using System;
using System.IO;

namespace Lesson5Reading
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Read the file
            //StreamReader rapunzelFile = File.OpenText("Rapunzel.txt");
            //string textOfRapunzel = rapunzelFile.ReadToEnd();

            // Console.Writelline(textOfRapunzel);

            //rapunzelFile.Close();






            // Line by reading
            //StreamReader rapunzelFile = File.OpenText("Rapunzel.txt");

            //string lineOfRapunzel = rapunzelFile.ReadLine();

            //while (lineOfRapunzel != null )
            //{
            //    Console.WriteLine(lineOfRapunzel);
            //    Console.WriteLine("------------");

            //    lineOfRapunzel = rapunzelFile.ReadLine();
            //}

            //rapunzelFile.Close();




            // Char by char
            //StreamReader rapunzelFile = File.OpenText("Rapunzel.txt");

            //while (rapunzelFile.EndOfStream == false)
            //{
            //    char c = Convert.ToChar(rapunzelFile.Read());

            //    Console.Write(c + " ");
            //}

            //rapunzelFile.Close();




            // Reading char by char by using a foreach loop
            StreamReader rapunzelStream = File.OpenText("Rapunzel.txt");
            String rapunzelText = rapunzelStream.ReadToEnd();

            string word = "";

            int countRapunzel = 0;

            foreach(char letter in rapunzelText)
            {
                if (letter == 32)
                {
                    if (word == "Rapunzel")
                    {
                        countRapunzel++;
                    }

                    Console.WriteLine(word);
                    word = "";
                } else
                {
                    word = word + letter;
                }
            }

            Console.WriteLine($"I have counted {countRapunzel} times");

            rapunzelStream.Close();
        }
    }
}



//input = File.OpenText("Rapunzel.txt");
//while (!input.EndOfStream)
//{
//    char c = (char)input.Read();
//    Console.Write(c + " ");
//}
//input.Close();







//StreamReader input = File.OpenText("Rapunzel.txt");
//string text = input.ReadToEnd();
//Console.Write(text);
//input.Close();