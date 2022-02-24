using System;
using System.IO; // Streamwriter, File, 

namespace Lesson5Files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // string path = Path.Combine(@"C:\", "file.txt");
            // StreamWriter stream = File.CreateText("collin.txt"); => bin/debug/collin.txt project

            // Create a path that I can use to write things in
            string path = Path.Combine("/Users/collinvandervorst/Desktop", "guestbox.txt"); //Users/collinvandervorst/Desktop/collin.txt

            // Opening streamWriter save it in variable called stread, using appendText so it will add lines to an exesting file
            Boolean isFileExisting = File.Exists(path);

            if (isFileExisting)
            {
                StreamWriter stream = File.AppendText(path);


                string firstname = Console.ReadLine(); // Collin
                stream.WriteLine(firstname);

                stream.Close();
            }


            // Deleting the collin2 file
            string pathCollin2 = Path.Combine("/Users/collinvandervorst/Desktop", "collin2.txt");

            if (File.Exists(pathCollin2))
            {
                File.Delete(pathCollin2);
            }
        }
    }
}
