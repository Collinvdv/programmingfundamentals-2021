using System;

using System.IO;

namespace Lesson5Files
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Variables input
            string path = Path.Combine("/Users/collinvandervorst/Desktop", "tomorrowland.txt");
            /// File.Exists() check if file is existing and store it in Boolean
            Boolean isFileExisting = File.Exists(path);

            // check if file is existing, if not create new file
            if (isFileExisting == false)
            {
                File.CreateText(path);
            }
            
            // add new lines
            StreamWriter output = File.AppendText(path);
            output.WriteLine("OMG A SECOND LINE IN THERE");
            output.Close();
        }
    }
}
